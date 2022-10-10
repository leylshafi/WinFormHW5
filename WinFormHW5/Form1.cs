using Guna.UI2.WinForms;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json;

namespace WinFormHW5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = FakeRepo.GetProducts().Count - 1; i >= 0; i--)
            {
                var userControl = new UC_Product(FakeRepo.GetProducts()[i],ref lbl_total);
                userControl.Dock = DockStyle.Top;
                pnl_products.Controls.Add(userControl);
            }


            AutoScrollMinSize = new Size(1300, 220 + pnl_products.PreferredSize.Height);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox)?.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Money_Click(object sender, EventArgs e)
        {
            double.TryParse((sender as Guna2CircleButton)?.Tag.ToString(), out double money);
            if (textBox1.Text == null)
                textBox1.Text = "0.00";
            double.TryParse(textBox1.Text, out double txtMoney);
            textBox1.Text = (money + txtMoney).ToString();
            lbl_total.Text = UC_Product.TotalMoney.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text,out double txtMoney);
            double.TryParse(lbl_total.Text,out double lblMoney);
            if(txtMoney - lblMoney < 0)
            {
                lbl_residue.Text = "0.00";
            }
            else lbl_residue.Text=(txtMoney-lblMoney).ToString();
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            if (lbl_total.Text == "0.00")
            {
                MessageBox.Show("You bought nothing, Good bye", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            double.TryParse(lbl_residue.Text,out double txtMoney);
            if (txtMoney<=0.00)
            {
                MessageBox.Show("Money is not enough", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DirectoryInfo directoryInfo = new(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Cheque");

            if (!directoryInfo.Exists)
                Directory.CreateDirectory(directoryInfo.FullName);

            List<string> boughtProducts = new();
            StringBuilder sb = new();
            sb.Append("You bought:\n");

            foreach (var product in UC_Product.checkedItems)
            {
                sb.Append($"{product.ToString()}\n");
            }
            

           sb.Append($"\nYou paid: {textBox1.Text}\n");
           sb.Append($"You receive: {lbl_residue.Text} back");
           Cheque ch = new Cheque(Guid.NewGuid(), sb.ToString(), DateTime.Now, "Ashley M. McGeehan");

            File.WriteAllText($@"{directoryInfo.FullName}\Cheque.json", System.Text.Json.JsonSerializer.Serialize(ch));

            var stringData = File.ReadAllText($@"{directoryInfo.FullName}\Cheque.json");
            ch = JsonConvert.DeserializeObject<Cheque>(stringData);
            MessageBox.Show(ch?.ToString());

        }
    }
}
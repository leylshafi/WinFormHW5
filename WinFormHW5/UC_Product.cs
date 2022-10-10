using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormHW5
{
    public partial class UC_Product : UserControl
    {

        public static double TotalMoney = 0;
        Label lab;
        public static List<string>checkedItems=new List<string>();
        public UC_Product(Product product,ref Label l)
        {

            InitializeComponent();
            lbl_productName.Text = product.Name;
            lbl_price.Text = product.Price.ToString();
            lab = l;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            double.TryParse(lbl_price.Text, out double price);
            foreach (var item in panel1.Controls)
            {
                if (item is NumericUpDown numeric)
                {
                    numeric.Enabled = checkBox1.Checked;
                   
                    if (numeric.Enabled == false)
                    {
                        checkedItems.Remove(lbl_productName.Text);
                        TotalMoney -= ((double)numeric.Value)*price;
                        numeric.Value = numeric.Minimum;
                        
                    }
                    else checkedItems.Add(lbl_productName.Text);
                }
            }

        }


        private void numericUpDown_ValueChanged(object sender, EventArgs e) 
        {
            double.TryParse(lbl_price.Text, out double price);
            double.TryParse((sender as NumericUpDown)?.Value.ToString(), out double count);
           
            TotalMoney += price * count;
            lab.Text = TotalMoney.ToString();
          
        }


    }
}

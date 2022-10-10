namespace WinFormHW5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_products = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TwentyCoin = new Guna.UI2.WinForms.Guna2CircleButton();
            this.TenCoin = new Guna.UI2.WinForms.Guna2CircleButton();
            this.FiftyCoin = new Guna.UI2.WinForms.Guna2CircleButton();
            this.TenManat = new Guna.UI2.WinForms.Guna2CircleButton();
            this.OneManat = new Guna.UI2.WinForms.Guna2CircleButton();
            this.FiveManat = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnl_totalMoney = new System.Windows.Forms.Panel();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_residue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_buy = new System.Windows.Forms.Button();
            this.pnl_totalMoney.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_products
            // 
            this.pnl_products.Location = new System.Drawing.Point(-3, 0);
            this.pnl_products.Name = "pnl_products";
            this.pnl_products.Size = new System.Drawing.Size(778, 672);
            this.pnl_products.TabIndex = 0;
            this.pnl_products.Tag = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(813, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter money:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(813, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // TwentyCoin
            // 
            this.TwentyCoin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TwentyCoin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TwentyCoin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TwentyCoin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TwentyCoin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TwentyCoin.ForeColor = System.Drawing.Color.White;
            this.TwentyCoin.Location = new System.Drawing.Point(941, 181);
            this.TwentyCoin.Name = "TwentyCoin";
            this.TwentyCoin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.TwentyCoin.Size = new System.Drawing.Size(111, 101);
            this.TwentyCoin.TabIndex = 3;
            this.TwentyCoin.Tag = "0.20";
            this.TwentyCoin.Text = "20 qep";
            this.TwentyCoin.Click += new System.EventHandler(this.Money_Click);
            // 
            // TenCoin
            // 
            this.TenCoin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TenCoin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TenCoin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TenCoin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TenCoin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TenCoin.ForeColor = System.Drawing.Color.White;
            this.TenCoin.Location = new System.Drawing.Point(796, 181);
            this.TenCoin.Name = "TenCoin";
            this.TenCoin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.TenCoin.Size = new System.Drawing.Size(111, 101);
            this.TenCoin.TabIndex = 3;
            this.TenCoin.Tag = "0.10";
            this.TenCoin.Text = "10 qep";
            this.TenCoin.Click += new System.EventHandler(this.Money_Click);
            // 
            // FiftyCoin
            // 
            this.FiftyCoin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FiftyCoin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FiftyCoin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FiftyCoin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FiftyCoin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FiftyCoin.ForeColor = System.Drawing.Color.White;
            this.FiftyCoin.Location = new System.Drawing.Point(1082, 181);
            this.FiftyCoin.Name = "FiftyCoin";
            this.FiftyCoin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.FiftyCoin.Size = new System.Drawing.Size(111, 101);
            this.FiftyCoin.TabIndex = 3;
            this.FiftyCoin.Tag = "0.50";
            this.FiftyCoin.Text = "50 qep";
            this.FiftyCoin.Click += new System.EventHandler(this.Money_Click);
            // 
            // TenManat
            // 
            this.TenManat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TenManat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TenManat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TenManat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TenManat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TenManat.ForeColor = System.Drawing.Color.White;
            this.TenManat.Location = new System.Drawing.Point(1082, 312);
            this.TenManat.Name = "TenManat";
            this.TenManat.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.TenManat.Size = new System.Drawing.Size(111, 101);
            this.TenManat.TabIndex = 3;
            this.TenManat.Tag = "10.00";
            this.TenManat.Text = "10 ₼";
            this.TenManat.Click += new System.EventHandler(this.Money_Click);
            // 
            // OneManat
            // 
            this.OneManat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OneManat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OneManat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OneManat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OneManat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OneManat.ForeColor = System.Drawing.Color.White;
            this.OneManat.Location = new System.Drawing.Point(796, 312);
            this.OneManat.Name = "OneManat";
            this.OneManat.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.OneManat.Size = new System.Drawing.Size(111, 101);
            this.OneManat.TabIndex = 3;
            this.OneManat.Tag = "1.00";
            this.OneManat.Text = "1 ₼";
            this.OneManat.Click += new System.EventHandler(this.Money_Click);
            // 
            // FiveManat
            // 
            this.FiveManat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FiveManat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FiveManat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FiveManat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FiveManat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FiveManat.ForeColor = System.Drawing.Color.White;
            this.FiveManat.Location = new System.Drawing.Point(941, 312);
            this.FiveManat.Name = "FiveManat";
            this.FiveManat.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.FiveManat.Size = new System.Drawing.Size(111, 101);
            this.FiveManat.TabIndex = 3;
            this.FiveManat.Tag = "5.00";
            this.FiveManat.Text = "5 ₼";
            this.FiveManat.Click += new System.EventHandler(this.Money_Click);
            // 
            // pnl_totalMoney
            // 
            this.pnl_totalMoney.Controls.Add(this.lbl_total);
            this.pnl_totalMoney.Controls.Add(this.label2);
            this.pnl_totalMoney.Location = new System.Drawing.Point(828, 451);
            this.pnl_totalMoney.Name = "pnl_totalMoney";
            this.pnl_totalMoney.Size = new System.Drawing.Size(236, 46);
            this.pnl_totalMoney.TabIndex = 4;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_total.Location = new System.Drawing.Point(124, 12);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(41, 21);
            this.lbl_total.TabIndex = 1;
            this.lbl_total.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total money: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_residue);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(828, 503);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 49);
            this.panel1.TabIndex = 5;
            // 
            // lbl_residue
            // 
            this.lbl_residue.AutoSize = true;
            this.lbl_residue.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_residue.Location = new System.Drawing.Point(104, 11);
            this.lbl_residue.Name = "lbl_residue";
            this.lbl_residue.Size = new System.Drawing.Size(50, 25);
            this.lbl_residue.TabIndex = 1;
            this.lbl_residue.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Residue:";
            // 
            // btn_buy
            // 
            this.btn_buy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_buy.Location = new System.Drawing.Point(941, 573);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(154, 62);
            this.btn_buy.TabIndex = 6;
            this.btn_buy.Text = "Buy";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 800);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_totalMoney);
            this.Controls.Add(this.OneManat);
            this.Controls.Add(this.TenManat);
            this.Controls.Add(this.TenCoin);
            this.Controls.Add(this.FiftyCoin);
            this.Controls.Add(this.FiveManat);
            this.Controls.Add(this.TwentyCoin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_products);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_totalMoney.ResumeLayout(false);
            this.pnl_totalMoney.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel pnl_products;
        private Label label1;
        private TextBox textBox1;
        private Guna.UI2.WinForms.Guna2CircleButton TwentyCoin;
        private Guna.UI2.WinForms.Guna2CircleButton TenCoin;
        private Guna.UI2.WinForms.Guna2CircleButton FiftyCoin;
        private Guna.UI2.WinForms.Guna2CircleButton TenManat;
        private Guna.UI2.WinForms.Guna2CircleButton OneManat;
        private Guna.UI2.WinForms.Guna2CircleButton FiveManat;
        private Label label2;
        private Panel panel1;
        private Label lbl_residue;
        private Label label3;
        private Button btn_buy;
        public Label lbl_total;
        internal Panel pnl_totalMoney;
    }
}
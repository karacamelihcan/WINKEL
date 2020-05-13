namespace Winkel
{
    partial class MainLogIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLogIN));
            this.SellerLogIn = new System.Windows.Forms.Button();
            this.sellerEmail = new System.Windows.Forms.TextBox();
            this.sellerPassword = new System.Windows.Forms.TextBox();
            this.customerEmail = new System.Windows.Forms.TextBox();
            this.customerPassword = new System.Windows.Forms.TextBox();
            this.CustomerLogIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSellerEmail = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SellerRegisterbtn = new System.Windows.Forms.Label();
            this.slrforgot = new System.Windows.Forms.Label();
            this.cstforgot = new System.Windows.Forms.Label();
            this.CustomerRegister = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SellerLogIn
            // 
            this.SellerLogIn.BackColor = System.Drawing.Color.Transparent;
            this.SellerLogIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SellerLogIn.BackgroundImage")));
            this.SellerLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SellerLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SellerLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellerLogIn.ForeColor = System.Drawing.Color.Silver;
            this.SellerLogIn.Location = new System.Drawing.Point(217, 551);
            this.SellerLogIn.Name = "SellerLogIn";
            this.SellerLogIn.Size = new System.Drawing.Size(227, 68);
            this.SellerLogIn.TabIndex = 2;
            this.SellerLogIn.UseVisualStyleBackColor = false;
            this.SellerLogIn.Click += new System.EventHandler(this.SellerLogIn_Click);
            // 
            // sellerEmail
            // 
            this.sellerEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sellerEmail.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sellerEmail.ForeColor = System.Drawing.Color.Silver;
            this.sellerEmail.Location = new System.Drawing.Point(217, 328);
            this.sellerEmail.Name = "sellerEmail";
            this.sellerEmail.Size = new System.Drawing.Size(245, 29);
            this.sellerEmail.TabIndex = 0;
            this.sellerEmail.Text = "Email";
            this.sellerEmail.Click += new System.EventHandler(this.sellerEmail_Click);
            this.sellerEmail.TextChanged += new System.EventHandler(this.sellerEmail_TextChanged);
            // 
            // sellerPassword
            // 
            this.sellerPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sellerPassword.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sellerPassword.ForeColor = System.Drawing.Color.Silver;
            this.sellerPassword.Location = new System.Drawing.Point(214, 418);
            this.sellerPassword.Name = "sellerPassword";
            this.sellerPassword.Size = new System.Drawing.Size(248, 29);
            this.sellerPassword.TabIndex = 1;
            this.sellerPassword.Text = "Password...";
            this.sellerPassword.UseSystemPasswordChar = true;
            this.sellerPassword.Click += new System.EventHandler(this.sellerPassword_Click);
            this.sellerPassword.TextChanged += new System.EventHandler(this.sellerPassword_TextChanged);
            // 
            // customerEmail
            // 
            this.customerEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerEmail.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerEmail.ForeColor = System.Drawing.Color.Silver;
            this.customerEmail.Location = new System.Drawing.Point(803, 326);
            this.customerEmail.Name = "customerEmail";
            this.customerEmail.Size = new System.Drawing.Size(267, 29);
            this.customerEmail.TabIndex = 3;
            this.customerEmail.Text = "Email";
            this.customerEmail.Click += new System.EventHandler(this.customerEmail_Click);
            this.customerEmail.TextChanged += new System.EventHandler(this.customerEmail_TextChanged);
            // 
            // customerPassword
            // 
            this.customerPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerPassword.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerPassword.ForeColor = System.Drawing.Color.Silver;
            this.customerPassword.Location = new System.Drawing.Point(803, 418);
            this.customerPassword.Name = "customerPassword";
            this.customerPassword.Size = new System.Drawing.Size(267, 29);
            this.customerPassword.TabIndex = 4;
            this.customerPassword.Text = "Password...";
            this.customerPassword.UseSystemPasswordChar = true;
            this.customerPassword.Click += new System.EventHandler(this.customerPassword_Click);
            this.customerPassword.TextChanged += new System.EventHandler(this.customerPassword_TextChanged);
            // 
            // CustomerLogIn
            // 
            this.CustomerLogIn.BackColor = System.Drawing.Color.Transparent;
            this.CustomerLogIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CustomerLogIn.BackgroundImage")));
            this.CustomerLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CustomerLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerLogIn.ForeColor = System.Drawing.Color.Silver;
            this.CustomerLogIn.Location = new System.Drawing.Point(818, 551);
            this.CustomerLogIn.Name = "CustomerLogIn";
            this.CustomerLogIn.Size = new System.Drawing.Size(227, 68);
            this.CustomerLogIn.TabIndex = 5;
            this.CustomerLogIn.UseVisualStyleBackColor = false;
            this.CustomerLogIn.Click += new System.EventHandler(this.CustomerLogIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(468, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(468, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1071, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1071, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "*";
            // 
            // lblSellerEmail
            // 
            this.lblSellerEmail.AutoSize = true;
            this.lblSellerEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblSellerEmail.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSellerEmail.Location = new System.Drawing.Point(213, 292);
            this.lblSellerEmail.Name = "lblSellerEmail";
            this.lblSellerEmail.Size = new System.Drawing.Size(0, 22);
            this.lblSellerEmail.TabIndex = 11;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerEmail.Location = new System.Drawing.Point(794, 292);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(0, 22);
            this.lblCustomerEmail.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(208, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Don\'t have an account?";
            // 
            // SellerRegisterbtn
            // 
            this.SellerRegisterbtn.AutoSize = true;
            this.SellerRegisterbtn.BackColor = System.Drawing.Color.Transparent;
            this.SellerRegisterbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SellerRegisterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SellerRegisterbtn.Location = new System.Drawing.Point(382, 480);
            this.SellerRegisterbtn.Name = "SellerRegisterbtn";
            this.SellerRegisterbtn.Size = new System.Drawing.Size(82, 20);
            this.SellerRegisterbtn.TabIndex = 14;
            this.SellerRegisterbtn.Text = "Register!";
            this.SellerRegisterbtn.Click += new System.EventHandler(this.SellerRegisterbtn_Click);
            // 
            // slrforgot
            // 
            this.slrforgot.AutoSize = true;
            this.slrforgot.BackColor = System.Drawing.Color.Transparent;
            this.slrforgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slrforgot.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.slrforgot.Location = new System.Drawing.Point(277, 500);
            this.slrforgot.Name = "slrforgot";
            this.slrforgot.Size = new System.Drawing.Size(130, 23);
            this.slrforgot.TabIndex = 17;
            this.slrforgot.Text = "Forgot Password ?";
            this.slrforgot.Click += new System.EventHandler(this.slrforgot_Click);
            // 
            // cstforgot
            // 
            this.cstforgot.AutoSize = true;
            this.cstforgot.BackColor = System.Drawing.Color.Transparent;
            this.cstforgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cstforgot.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cstforgot.Location = new System.Drawing.Point(870, 500);
            this.cstforgot.Name = "cstforgot";
            this.cstforgot.Size = new System.Drawing.Size(130, 23);
            this.cstforgot.TabIndex = 20;
            this.cstforgot.Text = "Forgot Password ?";
            this.cstforgot.Click += new System.EventHandler(this.cstforgot_Click);
            // 
            // CustomerRegister
            // 
            this.CustomerRegister.AutoSize = true;
            this.CustomerRegister.BackColor = System.Drawing.Color.Transparent;
            this.CustomerRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CustomerRegister.Location = new System.Drawing.Point(975, 480);
            this.CustomerRegister.Name = "CustomerRegister";
            this.CustomerRegister.Size = new System.Drawing.Size(82, 20);
            this.CustomerRegister.TabIndex = 19;
            this.CustomerRegister.Text = "Register!";
            this.CustomerRegister.Click += new System.EventHandler(this.CustomerRegister_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(801, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Don\'t have an account?";
            // 
            // MainLogIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1252, 769);
            this.Controls.Add(this.cstforgot);
            this.Controls.Add(this.CustomerRegister);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.slrforgot);
            this.Controls.Add(this.SellerRegisterbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCustomerEmail);
            this.Controls.Add(this.lblSellerEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerLogIn);
            this.Controls.Add(this.customerPassword);
            this.Controls.Add(this.customerEmail);
            this.Controls.Add(this.sellerPassword);
            this.Controls.Add(this.sellerEmail);
            this.Controls.Add(this.SellerLogIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1268, 808);
            this.MinimumSize = new System.Drawing.Size(1268, 808);
            this.Name = "MainLogIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winkel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SellerLogIn;
        private System.Windows.Forms.TextBox sellerEmail;
        private System.Windows.Forms.TextBox sellerPassword;
        private System.Windows.Forms.TextBox customerEmail;
        private System.Windows.Forms.TextBox customerPassword;
        private System.Windows.Forms.Button CustomerLogIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSellerEmail;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SellerRegisterbtn;
        private System.Windows.Forms.Label slrforgot;
        private System.Windows.Forms.Label cstforgot;
        private System.Windows.Forms.Label CustomerRegister;
        private System.Windows.Forms.Label label9;
    }
}
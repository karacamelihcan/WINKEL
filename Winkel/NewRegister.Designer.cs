namespace Winkel
{
    partial class NewRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewRegister));
            this.backbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.SName = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.CityList = new System.Windows.Forms.ComboBox();
            this.Register = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Photo = new System.Windows.Forms.TextBox();
            this.Upload = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblPasswordStrong = new System.Windows.Forms.Label();
            this.lblUyarı = new System.Windows.Forms.Label();
            this.SeePassword = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.Transparent;
            this.backbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backbutton.BackgroundImage")));
            this.backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.ForeColor = System.Drawing.Color.Silver;
            this.backbutton.Location = new System.Drawing.Point(42, 40);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(41, 40);
            this.backbutton.TabIndex = 0;
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(146, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(115, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(148, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(113, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(545, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "City:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(120, 391);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(308, 15);
            this.progressBar.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(528, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Photo:";
            // 
            // SName
            // 
            this.SName.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SName.ForeColor = System.Drawing.Color.Silver;
            this.SName.Location = new System.Drawing.Point(228, 194);
            this.SName.Name = "SName";
            this.SName.Size = new System.Drawing.Size(200, 36);
            this.SName.TabIndex = 1;
            this.SName.Text = "Name";
            this.SName.Click += new System.EventHandler(this.SName_Click);
            // 
            // Surname
            // 
            this.Surname.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Surname.ForeColor = System.Drawing.Color.Silver;
            this.Surname.Location = new System.Drawing.Point(228, 245);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(200, 36);
            this.Surname.TabIndex = 2;
            this.Surname.Text = "Surname";
            this.Surname.Click += new System.EventHandler(this.Surname_Click);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Email.ForeColor = System.Drawing.Color.Silver;
            this.Email.Location = new System.Drawing.Point(228, 296);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(200, 36);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Password.ForeColor = System.Drawing.Color.Silver;
            this.Password.Location = new System.Drawing.Point(228, 347);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(200, 36);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password";
            this.Password.UseSystemPasswordChar = true;
            this.Password.Click += new System.EventHandler(this.Password_Click);
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // CityList
            // 
            this.CityList.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CityList.FormattingEnabled = true;
            this.CityList.Location = new System.Drawing.Point(622, 244);
            this.CityList.Name = "CityList";
            this.CityList.Size = new System.Drawing.Size(149, 36);
            this.CityList.TabIndex = 5;
            // 
            // Register
            // 
            this.Register.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Register.BackgroundImage")));
            this.Register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register.ForeColor = System.Drawing.Color.Silver;
            this.Register.Location = new System.Drawing.Point(569, 511);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(168, 54);
            this.Register.TabIndex = 14;
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Clear
            // 
            this.Clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Clear.BackgroundImage")));
            this.Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.ForeColor = System.Drawing.Color.Silver;
            this.Clear.Location = new System.Drawing.Point(286, 511);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(168, 54);
            this.Clear.TabIndex = 15;
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Photo
            // 
            this.Photo.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Photo.ForeColor = System.Drawing.Color.Silver;
            this.Photo.Location = new System.Drawing.Point(622, 296);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(149, 36);
            this.Photo.TabIndex = 6;
            this.Photo.Text = "Upload a file";
            this.Photo.Click += new System.EventHandler(this.Photo_Click);
            // 
            // Upload
            // 
            this.Upload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Upload.BackgroundImage")));
            this.Upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Upload.ForeColor = System.Drawing.Color.Silver;
            this.Upload.Location = new System.Drawing.Point(819, 294);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(118, 38);
            this.Upload.TabIndex = 17;
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(434, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(434, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(434, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 28);
            this.label9.TabIndex = 21;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(434, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 28);
            this.label10.TabIndex = 20;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(777, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 28);
            this.label11.TabIndex = 22;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(777, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 28);
            this.label12.TabIndex = 23;
            this.label12.Text = "*";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(729, 72);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 150);
            this.pictureBox.TabIndex = 24;
            this.pictureBox.TabStop = false;
            // 
            // lblPasswordStrong
            // 
            this.lblPasswordStrong.AutoSize = true;
            this.lblPasswordStrong.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordStrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPasswordStrong.Location = new System.Drawing.Point(434, 393);
            this.lblPasswordStrong.Name = "lblPasswordStrong";
            this.lblPasswordStrong.Size = new System.Drawing.Size(0, 16);
            this.lblPasswordStrong.TabIndex = 25;
            // 
            // lblUyarı
            // 
            this.lblUyarı.AutoSize = true;
            this.lblUyarı.BackColor = System.Drawing.Color.Transparent;
            this.lblUyarı.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyarı.ForeColor = System.Drawing.Color.Red;
            this.lblUyarı.Location = new System.Drawing.Point(350, 455);
            this.lblUyarı.Name = "lblUyarı";
            this.lblUyarı.Size = new System.Drawing.Size(0, 28);
            this.lblUyarı.TabIndex = 26;
            // 
            // SeePassword
            // 
            this.SeePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SeePassword.BackgroundImage")));
            this.SeePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SeePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeePassword.ForeColor = System.Drawing.Color.Silver;
            this.SeePassword.Location = new System.Drawing.Point(460, 352);
            this.SeePassword.Name = "SeePassword";
            this.SeePassword.Size = new System.Drawing.Size(28, 31);
            this.SeePassword.TabIndex = 27;
            this.SeePassword.UseVisualStyleBackColor = true;
            this.SeePassword.Click += new System.EventHandler(this.SeePassword_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // NewRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 633);
            this.Controls.Add(this.SeePassword);
            this.Controls.Add(this.lblUyarı);
            this.Controls.Add(this.lblPasswordStrong);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.CityList);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.SName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backbutton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1032, 672);
            this.MinimumSize = new System.Drawing.Size(1032, 672);
            this.Name = "NewRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winkel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SellerRegister_FormClosed);
            this.Load += new System.EventHandler(this.SellerRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SName;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.ComboBox CityList;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox Photo;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblPasswordStrong;
        private System.Windows.Forms.Label lblUyarı;
        private System.Windows.Forms.Button SeePassword;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
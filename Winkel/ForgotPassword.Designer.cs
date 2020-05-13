namespace Winkel
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.backbutton = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.sendEmail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.backbutton.Location = new System.Drawing.Point(66, 48);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(41, 40);
            this.backbutton.TabIndex = 1;
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Email.Location = new System.Drawing.Point(444, 352);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(264, 36);
            this.Email.TabIndex = 2;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // sendEmail
            // 
            this.sendEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sendEmail.BackgroundImage")));
            this.sendEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendEmail.ForeColor = System.Drawing.Color.Silver;
            this.sendEmail.Location = new System.Drawing.Point(501, 479);
            this.sendEmail.Name = "sendEmail";
            this.sendEmail.Size = new System.Drawing.Size(162, 55);
            this.sendEmail.TabIndex = 3;
            this.sendEmail.UseVisualStyleBackColor = true;
            this.sendEmail.Click += new System.EventHandler(this.sendEmail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(400, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 4;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1157, 678);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendEmail);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.backbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1173, 717);
            this.MinimumSize = new System.Drawing.Size(1173, 717);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winkel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ForgotPassword_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Button sendEmail;
        private System.Windows.Forms.Label label1;
    }
}
namespace Winkel
{
    partial class NotificationScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationScreen));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.SellerLogIn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(22, 179);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Size = new System.Drawing.Size(1162, 169);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            // 
            // SellerLogIn
            // 
            this.SellerLogIn.BackColor = System.Drawing.Color.Transparent;
            this.SellerLogIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SellerLogIn.BackgroundImage")));
            this.SellerLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SellerLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SellerLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellerLogIn.ForeColor = System.Drawing.Color.Silver;
            this.SellerLogIn.Location = new System.Drawing.Point(644, 60);
            this.SellerLogIn.Name = "SellerLogIn";
            this.SellerLogIn.Size = new System.Drawing.Size(227, 68);
            this.SellerLogIn.TabIndex = 3;
            this.SellerLogIn.UseVisualStyleBackColor = false;
            this.SellerLogIn.Click += new System.EventHandler(this.SellerLogIn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(911, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 68);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NotificationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1206, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SellerLogIn);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1222, 417);
            this.MinimumSize = new System.Drawing.Size(1222, 417);
            this.Name = "NotificationScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winkel";
            this.Load += new System.EventHandler(this.Notification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button SellerLogIn;
        private System.Windows.Forms.Button button1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}
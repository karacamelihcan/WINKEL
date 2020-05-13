namespace Winkel
{
    partial class PastOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PastOperations));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.Label();
            this.ProductNameLbl = new System.Windows.Forms.Label();
            this.Volume = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.FName = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.ProductVolume = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ProductCode = new System.Windows.Forms.TextBox();
            this.ProductCategory = new System.Windows.Forms.TextBox();
            this.SalesNumberLbl = new System.Windows.Forms.Label();
            this.ProductCost = new System.Windows.Forms.TextBox();
            this.SalesNumber = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductUnit = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.backbutton.Location = new System.Drawing.Point(34, 36);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(41, 40);
            this.backbutton.TabIndex = 29;
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Location = new System.Drawing.Point(34, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 274);
            this.panel1.TabIndex = 30;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Size = new System.Drawing.Size(1111, 274);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(73, 197);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(153, 26);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "Customer Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblSurname.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.Location = new System.Drawing.Point(50, 239);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(176, 26);
            this.lblSurname.TabIndex = 32;
            this.lblSurname.Text = "Customer Surname:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(76, 281);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(150, 26);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Customer Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(90, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 26);
            this.label4.TabIndex = 34;
            this.label4.Text = "Customer City:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory.Location = new System.Drawing.Point(429, 200);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(161, 26);
            this.lblCategory.TabIndex = 35;
            this.lblCategory.Text = "Product Category:";
            // 
            // Code
            // 
            this.Code.AutoSize = true;
            this.Code.BackColor = System.Drawing.Color.Transparent;
            this.Code.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Code.Location = new System.Drawing.Point(461, 239);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(129, 26);
            this.Code.TabIndex = 36;
            this.Code.Text = "Product Code:";
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.ProductNameLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductNameLbl.Location = new System.Drawing.Point(452, 281);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(138, 26);
            this.ProductNameLbl.TabIndex = 37;
            this.ProductNameLbl.Text = "Product Name:";
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.BackColor = System.Drawing.Color.Transparent;
            this.Volume.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Volume.Location = new System.Drawing.Point(507, 323);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(83, 26);
            this.Volume.TabIndex = 38;
            this.Volume.Text = "Volume:";
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.BackColor = System.Drawing.Color.Transparent;
            this.Cost.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cost.Location = new System.Drawing.Point(875, 326);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(53, 26);
            this.Cost.TabIndex = 40;
            this.Cost.Text = "Cost:";
            // 
            // FName
            // 
            this.FName.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FName.Location = new System.Drawing.Point(228, 197);
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            this.FName.Size = new System.Drawing.Size(192, 33);
            this.FName.TabIndex = 43;
            // 
            // Surname
            // 
            this.Surname.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Surname.Location = new System.Drawing.Point(228, 239);
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            this.Surname.Size = new System.Drawing.Size(192, 33);
            this.Surname.TabIndex = 44;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Email.Location = new System.Drawing.Point(228, 281);
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Size = new System.Drawing.Size(192, 33);
            this.Email.TabIndex = 45;
            // 
            // City
            // 
            this.City.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.City.Location = new System.Drawing.Point(228, 323);
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Size = new System.Drawing.Size(192, 33);
            this.City.TabIndex = 46;
            // 
            // ProductVolume
            // 
            this.ProductVolume.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductVolume.Location = new System.Drawing.Point(596, 320);
            this.ProductVolume.Name = "ProductVolume";
            this.ProductVolume.ReadOnly = true;
            this.ProductVolume.Size = new System.Drawing.Size(68, 33);
            this.ProductVolume.TabIndex = 50;
            // 
            // ProductName
            // 
            this.ProductName.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductName.Location = new System.Drawing.Point(596, 278);
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Size = new System.Drawing.Size(192, 33);
            this.ProductName.TabIndex = 49;
            // 
            // ProductCode
            // 
            this.ProductCode.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductCode.Location = new System.Drawing.Point(596, 236);
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            this.ProductCode.Size = new System.Drawing.Size(192, 33);
            this.ProductCode.TabIndex = 48;
            // 
            // ProductCategory
            // 
            this.ProductCategory.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductCategory.Location = new System.Drawing.Point(596, 194);
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.ReadOnly = true;
            this.ProductCategory.Size = new System.Drawing.Size(192, 33);
            this.ProductCategory.TabIndex = 47;
            // 
            // SalesNumberLbl
            // 
            this.SalesNumberLbl.AutoSize = true;
            this.SalesNumberLbl.BackColor = System.Drawing.Color.Transparent;
            this.SalesNumberLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SalesNumberLbl.Location = new System.Drawing.Point(794, 284);
            this.SalesNumberLbl.Name = "SalesNumberLbl";
            this.SalesNumberLbl.Size = new System.Drawing.Size(134, 26);
            this.SalesNumberLbl.TabIndex = 39;
            this.SalesNumberLbl.Text = "Sales Number:";
            // 
            // ProductCost
            // 
            this.ProductCost.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductCost.Location = new System.Drawing.Point(934, 323);
            this.ProductCost.Name = "ProductCost";
            this.ProductCost.ReadOnly = true;
            this.ProductCost.Size = new System.Drawing.Size(129, 33);
            this.ProductCost.TabIndex = 54;
            // 
            // SalesNumber
            // 
            this.SalesNumber.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SalesNumber.Location = new System.Drawing.Point(934, 281);
            this.SalesNumber.Name = "SalesNumber";
            this.SalesNumber.ReadOnly = true;
            this.SalesNumber.Size = new System.Drawing.Size(192, 33);
            this.SalesNumber.TabIndex = 53;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(898, 37);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(228, 228);
            this.pictureBox.TabIndex = 55;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1069, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 28);
            this.label1.TabIndex = 56;
            this.label1.Text = "₺";
            // 
            // ProductUnit
            // 
            this.ProductUnit.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductUnit.Location = new System.Drawing.Point(670, 319);
            this.ProductUnit.Name = "ProductUnit";
            this.ProductUnit.ReadOnly = true;
            this.ProductUnit.Size = new System.Drawing.Size(118, 33);
            this.ProductUnit.TabIndex = 57;
            // 
            // PastOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 735);
            this.Controls.Add(this.ProductUnit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.ProductCost);
            this.Controls.Add(this.SalesNumber);
            this.Controls.Add(this.ProductVolume);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.ProductCode);
            this.Controls.Add(this.ProductCategory);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.SalesNumberLbl);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.ProductNameLbl);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1195, 774);
            this.MinimumSize = new System.Drawing.Size(1195, 774);
            this.Name = "PastOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winkel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PastOperations_FormClosed);
            this.Load += new System.EventHandler(this.PastOperations_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.Label ProductNameLbl;
        private System.Windows.Forms.Label Volume;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox ProductVolume;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox ProductCode;
        private System.Windows.Forms.TextBox ProductCategory;
        private System.Windows.Forms.Label SalesNumberLbl;
        private System.Windows.Forms.TextBox ProductCost;
        private System.Windows.Forms.TextBox SalesNumber;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductUnit;
    }
}
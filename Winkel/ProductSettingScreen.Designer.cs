namespace Winkel
{
    partial class ProductSettingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSettingScreen));
            this.panel = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.cbStatu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ProductPhoto = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.stockNumber = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.tbVolume = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Upload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.NotfBtn = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.clearfilter = new System.Windows.Forms.Label();
            this.lblUyarı = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblID = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dataGridView);
            this.panel.Location = new System.Drawing.Point(37, 446);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1250, 272);
            this.panel.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.Silver;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1250, 272);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBtn.BackgroundImage")));
            this.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.ForeColor = System.Drawing.Color.Silver;
            this.AddBtn.Location = new System.Drawing.Point(1060, 137);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(227, 68);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.BackgroundImage")));
            this.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.ForeColor = System.Drawing.Color.Silver;
            this.DeleteBtn.Location = new System.Drawing.Point(1060, 216);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(227, 68);
            this.DeleteBtn.TabIndex = 6;
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.BackgroundImage")));
            this.UpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.ForeColor = System.Drawing.Color.Silver;
            this.UpdateBtn.Location = new System.Drawing.Point(1060, 295);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(227, 68);
            this.UpdateBtn.TabIndex = 7;
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // cbStatu
            // 
            this.cbStatu.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbStatu.FormattingEnabled = true;
            this.cbStatu.Location = new System.Drawing.Point(683, 295);
            this.cbStatu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStatu.Name = "cbStatu";
            this.cbStatu.Size = new System.Drawing.Size(159, 36);
            this.cbStatu.TabIndex = 104;
            this.cbStatu.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(551, 303);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 28);
            this.label8.TabIndex = 103;
            this.label8.Text = "Stock Statu:";
            // 
            // ProductPhoto
            // 
            this.ProductPhoto.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductPhoto.Location = new System.Drawing.Point(683, 245);
            this.ProductPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductPhoto.Name = "ProductPhoto";
            this.ProductPhoto.ReadOnly = true;
            this.ProductPhoto.Size = new System.Drawing.Size(112, 36);
            this.ProductPhoto.TabIndex = 102;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.price.Location = new System.Drawing.Point(683, 199);
            this.price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(112, 36);
            this.price.TabIndex = 101;
            // 
            // stockNumber
            // 
            this.stockNumber.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stockNumber.Location = new System.Drawing.Point(683, 155);
            this.stockNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stockNumber.Name = "stockNumber";
            this.stockNumber.Size = new System.Drawing.Size(159, 36);
            this.stockNumber.TabIndex = 100;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(606, 250);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 28);
            this.label19.TabIndex = 99;
            this.label19.Text = "Photo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(610, 205);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 28);
            this.label20.TabIndex = 98;
            this.label20.Text = "Price:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(525, 160);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(150, 28);
            this.label21.TabIndex = 97;
            this.label21.Text = "StockNumber:";
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(167, 151);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(264, 36);
            this.cbCategory.TabIndex = 96;
            // 
            // cbUnit
            // 
            this.cbUnit.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(167, 327);
            this.cbUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(217, 36);
            this.cbUnit.TabIndex = 95;
            // 
            // tbVolume
            // 
            this.tbVolume.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbVolume.Location = new System.Drawing.Point(167, 283);
            this.tbVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(217, 36);
            this.tbVolume.TabIndex = 94;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbName.Location = new System.Drawing.Point(167, 239);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(217, 36);
            this.tbName.TabIndex = 93;
            // 
            // tbCode
            // 
            this.tbCode.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbCode.Location = new System.Drawing.Point(167, 195);
            this.tbCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(217, 36);
            this.tbCode.TabIndex = 92;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(105, 335);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 28);
            this.label9.TabIndex = 91;
            this.label9.Text = "Unit:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(70, 291);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 28);
            this.label10.TabIndex = 90;
            this.label10.Text = "Volume:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(88, 247);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 28);
            this.label11.TabIndex = 89;
            this.label11.Text = "Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(91, 203);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 28);
            this.label12.TabIndex = 88;
            this.label12.Text = "Code:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(55, 159);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 28);
            this.label13.TabIndex = 87;
            this.label13.Text = "Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(803, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 28);
            this.label1.TabIndex = 105;
            this.label1.Text = "₺";
            // 
            // Upload
            // 
            this.Upload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Upload.BackgroundImage")));
            this.Upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Upload.ForeColor = System.Drawing.Color.Silver;
            this.Upload.Location = new System.Drawing.Point(859, 240);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(118, 38);
            this.Upload.TabIndex = 106;
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(883, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(163, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 54);
            this.panel1.TabIndex = 108;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.White;
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSearch.ForeColor = System.Drawing.Color.Black;
            this.tbSearch.Location = new System.Drawing.Point(21, 14);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(223, 26);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // NotfBtn
            // 
            this.NotfBtn.BackColor = System.Drawing.Color.Transparent;
            this.NotfBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NotfBtn.BackgroundImage")));
            this.NotfBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NotfBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotfBtn.ForeColor = System.Drawing.Color.Silver;
            this.NotfBtn.Location = new System.Drawing.Point(437, 65);
            this.NotfBtn.Name = "NotfBtn";
            this.NotfBtn.Size = new System.Drawing.Size(54, 52);
            this.NotfBtn.TabIndex = 109;
            this.NotfBtn.UseVisualStyleBackColor = false;
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.Transparent;
            this.backbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backbutton.BackgroundImage")));
            this.backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.ForeColor = System.Drawing.Color.Silver;
            this.backbutton.Location = new System.Drawing.Point(49, 48);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(41, 40);
            this.backbutton.TabIndex = 110;
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // clearfilter
            // 
            this.clearfilter.AutoSize = true;
            this.clearfilter.BackColor = System.Drawing.Color.Transparent;
            this.clearfilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearfilter.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clearfilter.ForeColor = System.Drawing.Color.Red;
            this.clearfilter.Location = new System.Drawing.Point(497, 79);
            this.clearfilter.Name = "clearfilter";
            this.clearfilter.Size = new System.Drawing.Size(127, 22);
            this.clearfilter.TabIndex = 111;
            this.clearfilter.Text = "CLEAR FILTERS";
            this.clearfilter.Visible = false;
            this.clearfilter.Click += new System.EventHandler(this.clearfilter_Click);
            // 
            // lblUyarı
            // 
            this.lblUyarı.AutoSize = true;
            this.lblUyarı.BackColor = System.Drawing.Color.Transparent;
            this.lblUyarı.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyarı.ForeColor = System.Drawing.Color.Red;
            this.lblUyarı.Location = new System.Drawing.Point(587, 400);
            this.lblUyarı.Name = "lblUyarı";
            this.lblUyarı.Size = new System.Drawing.Size(0, 26);
            this.lblUyarı.TabIndex = 112;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(438, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 26);
            this.label2.TabIndex = 113;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(391, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 26);
            this.label3.TabIndex = 114;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(391, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 26);
            this.label4.TabIndex = 115;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(391, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 26);
            this.label5.TabIndex = 117;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(391, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 26);
            this.label6.TabIndex = 116;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(849, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 26);
            this.label7.TabIndex = 118;
            this.label7.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(834, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 26);
            this.label14.TabIndex = 119;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(803, 249);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 26);
            this.label15.TabIndex = 120;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(849, 305);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 26);
            this.label16.TabIndex = 121;
            this.label16.Text = "*";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(637, 393);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 122;
            this.lblID.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Silver;
            this.btnClear.Location = new System.Drawing.Point(1060, 372);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(227, 68);
            this.btnClear.TabIndex = 123;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ProductSettingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1324, 766);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUyarı);
            this.Controls.Add(this.clearfilter);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.NotfBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStatu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ProductPhoto);
            this.Controls.Add(this.price);
            this.Controls.Add(this.stockNumber);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1340, 805);
            this.MinimumSize = new System.Drawing.Size(1340, 805);
            this.Name = "ProductSettingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductSettingScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductSettingScreen_FormClosed);
            this.Load += new System.EventHandler(this.ProductSettingScreen_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.ComboBox cbStatu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ProductPhoto;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox stockNumber;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.TextBox tbVolume;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button NotfBtn;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label clearfilter;
        private System.Windows.Forms.Label lblUyarı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnClear;
    }
}
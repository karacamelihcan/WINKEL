namespace Winkel
{
    partial class ShoppingList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ClearAllProductBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(940, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 68);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.ClearBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearBtn.BackgroundImage")));
            this.ClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.ForeColor = System.Drawing.Color.Silver;
            this.ClearBtn.Location = new System.Drawing.Point(690, 59);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(227, 68);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(23, 164);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Size = new System.Drawing.Size(1162, 206);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // ClearAllProductBtn
            // 
            this.ClearAllProductBtn.BackColor = System.Drawing.Color.Transparent;
            this.ClearAllProductBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearAllProductBtn.BackgroundImage")));
            this.ClearAllProductBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearAllProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearAllProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAllProductBtn.ForeColor = System.Drawing.Color.Silver;
            this.ClearAllProductBtn.Location = new System.Drawing.Point(446, 59);
            this.ClearAllProductBtn.Name = "ClearAllProductBtn";
            this.ClearAllProductBtn.Size = new System.Drawing.Size(227, 68);
            this.ClearAllProductBtn.TabIndex = 8;
            this.ClearAllProductBtn.UseVisualStyleBackColor = false;
            this.ClearAllProductBtn.Click += new System.EventHandler(this.ClearAllProductBtn_Click);
            // 
            // ShoppingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1206, 407);
            this.Controls.Add(this.ClearAllProductBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1222, 446);
            this.MinimumSize = new System.Drawing.Size(1222, 446);
            this.Name = "ShoppingList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winkel";
            this.Load += new System.EventHandler(this.ShoppingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button ClearAllProductBtn;
    }
}
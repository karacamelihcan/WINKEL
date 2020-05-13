using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winkel.Contracts.Response.Seller;
using Winkel.Services;

namespace Winkel
{
    public partial class ProductSettingScreen : Form
    {
        private SellerHomePage sellerHomePage;
        private SellerInformationResponse seller;
        private ISellerService sellerService = new SellerService();
        public ProductSettingScreen(SellerHomePage sellerHomePage, SellerInformationResponse seller)
        {
            InitializeComponent();
            this.sellerHomePage = sellerHomePage;
            this.seller = seller;
        }

        private void ProductSettingScreen_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = sellerService.AllProductList(new Contracts.Request.Product.AllProductRequest(seller.SellerID));
            var categorylist = sellerService.CategoryList();
            cbCategory.DataSource = categorylist;
            cbCategory.DisplayMember = "CategoryName";
            var UnitList = sellerService.UnitList();
            cbUnit.DataSource = UnitList;
            cbUnit.DisplayMember = "UnitName";
            var statulist = sellerService.StockStatusList();
            cbStatu.DataSource = statulist;
            cbStatu.DisplayMember = "StockStatus";
            
        }

   
        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductSettingScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sellerHomePage != null)
            {
                sellerHomePage.Show();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if(tbSearch.Text!=null || tbSearch.Text != "")
            {
                clearfilter.Visible = true;
            }
            if (tbSearch.Text == "")
            {
                clearfilter.Visible = false;
            }
            dataGridView.DataSource = sellerService.SellerProductSearch(new Contracts.Request.Product.SellerProductSearchRequest(seller.SellerID,tbSearch.Text));
        }

        private void clearfilter_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
            clearfilter.Visible = false;
            dataGridView.DataSource = sellerService.AllProductList(new Contracts.Request.Product.AllProductRequest(seller.SellerID));
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbCategory.Text==""|| tbCode.Text == ""|| tbName.Text == "" || tbVolume.Text == "" || cbUnit.Text==""|| stockNumber.Text == ""||price.Text == "" || ProductPhoto.Text == "" || cbStatu.Text == "")
                {
                    lblUyarı.Text = "All fields mark with (*) are mandatory !";
                }
                else
                {
                    lblUyarı.Text = "";
                    if (Convert.ToInt16(tbVolume.Text) < 0 || (isValid(tbVolume.Text)))
                    {
                        lblUyarı.Text = "Please, enter a valid volume !";
                    }
                    else
                    {
                        lblUyarı.Text = "";
                        if (Convert.ToInt16(stockNumber.Text) < 0 || isValid(stockNumber.Text))
                        {
                            lblUyarı.Text = "Please, enter a valid stock number !";
                        }
                        else
                        {
                            lblUyarı.Text = "";
                            if (Convert.ToDecimal(price.Text) < 0 || isValid(price.Text))
                            {
                                lblUyarı.Text = "Please, enter a valid price !";
                            }
                            else
                            {
                                lblUyarı.Text = "";
                                if (ProductPhoto.Text == "openFileDialog")
                                {
                                    lblUyarı.Text = "Please, upload a valid photo !";
                                }
                                else
                                {
                                    lblUyarı.Text = "";
                                    if (sellerService.CheckProductExist(new Contracts.Request.Product.CheckProductExistRequest(tbCode.Text, tbName.Text, Convert.ToInt16(tbVolume.Text), cbUnit.Text, seller.SellerID)) == false)
                                    {
                                        sellerService.AddProduct(new Contracts.Request.Product.AddProductRequest(cbCategory.Text, tbCode.Text, tbName.Text, Convert.ToInt16(tbVolume.Text), cbUnit.Text, seller.SellerID, Convert.ToInt16(stockNumber.Text), Convert.ToDecimal(price.Text), ProductPhoto.Text));
                                        dataGridView.DataSource = sellerService.AllProductList(new Contracts.Request.Product.AllProductRequest(seller.SellerID));
                                        ShowAutoClosingMessageBoxInfo("Added successfull", "Successfull");
                                    }
                                    else
                                    {
                                        lblUyarı.Text = "You have already added this product";
                                    }
                                }
                            }
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog.FileName;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            ProductPhoto.Text = openFileDialog.FileName;
        }
        public int Id;
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dataGridView.SelectedRows.Count > 0)
                {
                    Id = int.Parse(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    lblID.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                    string CategoryName = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                    string ProductCode = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                    string ProductName = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                    string Volume = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                    string UnitName = dataGridView.SelectedRows[0].Cells[5].Value.ToString();
                    string StockNumber = dataGridView.SelectedRows[0].Cells[6].Value.ToString();
                    string Price = dataGridView.SelectedRows[0].Cells[7].Value.ToString();
                    string Photo = dataGridView.SelectedRows[0].Cells[8].Value.ToString();
                    string statu = dataGridView.SelectedRows[0].Cells[9].Value.ToString();
                    
                    cbCategory.Text = CategoryName;
                    tbCode.Text = ProductCode;
                    tbName.Text = ProductName;
                    tbVolume.Text = Volume;
                    cbUnit.Text = UnitName;
                    stockNumber.Text = StockNumber;
                    price.Text = Price;
                    ProductPhoto.Text = Photo;
                    pictureBox1.ImageLocation = Photo;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    cbStatu.Text = statu;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void clear()
        {
            cbCategory.Text = "";
            tbCode.Clear();
            tbName.Clear();
            tbVolume.Clear();
            cbUnit.Text = "";
            stockNumber.Clear();
            price.Clear();
            ProductPhoto.Clear();
            cbStatu.Text = "";
            lblID.Text = "";
            pictureBox1.Image = null;
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblID.Text != "")
                {
                    if(MessageBox.Show("Are you sure you want to delete this product? \n This item will be deleted immediately,You can't undo this action!", "Winkel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        sellerService.DeleteProduct(new Contracts.Request.Product.DeleteProductRequest(Id));
                        clear();
                        dataGridView.DataSource = sellerService.AllProductList(new Contracts.Request.Product.AllProductRequest(seller.SellerID));
                        ShowAutoClosingMessageBoxInfo("Delete successfull", "Successfull");
                    }
                }
                else
                {
                    lblUyarı.Text = "Please, select a record!";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblID.Text != "")
                {
                    if (cbCategory.Text == "" || tbCode.Text == "" || tbName.Text == "" || tbVolume.Text == "" || cbUnit.Text == "" || stockNumber.Text == "" || price.Text == "" || ProductPhoto.Text == "" || cbStatu.Text == "")
                    {
                        lblUyarı.Text = "All fields mark with (*) are mandatory !";
                    }
                    else
                    {
                        lblUyarı.Text = "";
                        if (Convert.ToInt16(tbVolume.Text) < 0 || (isValid(tbVolume.Text)))
                        {
                            lblUyarı.Text = "Please, enter a valid volume !";
                        }
                        else
                        {
                            lblUyarı.Text = "";
                            if (Convert.ToInt16(stockNumber.Text) < 0 || isValid(stockNumber.Text))
                            {
                                lblUyarı.Text = "Please, enter a valid stock number !";
                            }
                            else
                            {
                                lblUyarı.Text = "";
                                if (Convert.ToDecimal(price.Text) < 0 || isValid(price.Text))
                                {
                                    lblUyarı.Text = "Please, enter a valid price !";
                                }
                                else
                                {
                                    lblUyarı.Text = "";
                                    if (ProductPhoto.Text == "openFileDialog")
                                    {
                                        lblUyarı.Text = "Please, upload a valid photo !";
                                    }
                                    else
                                    {
                                        if (MessageBox.Show("Are you sure you want to update this product?", "Winkel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            lblUyarı.Text = "";
                                            sellerService.UpdateProduct(new Contracts.Request.Product.UpdateProductRequest(Id, cbCategory.Text, tbCode.Text, tbName.Text, Convert.ToInt16(tbVolume.Text), cbUnit.Text, seller.SellerID, Convert.ToInt16(stockNumber.Text), cbStatu.Text, Convert.ToDecimal(price.Text), ProductPhoto.Text));
                                            dataGridView.DataSource = sellerService.AllProductList(new Contracts.Request.Product.AllProductRequest(seller.SellerID));
                                            ShowAutoClosingMessageBoxInfo("Update successfull", "Successfull");
                                        }
                                        
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    lblUyarı.Text = "Please, select a record!";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        [DllImport("user32.Dll")]
        static extern int PostMessage(IntPtr hWnd, UInt32 msg, int wParam, int lParam);

        private const UInt32 WM_CLOSE = 0x0010;

        public void ShowAutoClosingMessageBoxInfo(string message, string caption)
        {
            var timer = new System.Timers.Timer(5000) { AutoReset = false };
            timer.Elapsed += delegate
            {
                IntPtr hWnd = FindWindowByCaption(IntPtr.Zero, caption);
                if (hWnd.ToInt32() != 0) PostMessage(hWnd, WM_CLOSE, 0, 0);
            };
            timer.Enabled = true;
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private static bool isValid(String str)
        {
            return Regex.IsMatch(str, @"^[a-zA-Z]+$");
        }
    }
}

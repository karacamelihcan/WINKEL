using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winkel.Contracts.Response.Customer;
using Winkel.Services;
using Winkel.Services.ProductServices;
using WinkelDAL.Model;

namespace Winkel
{
    public partial class DiscoverProduct : Form
    {
        private CustomerHomePage customerHomePage;
        private CustomerInfoResponse customer;
        private ICustomerService customerService = new CustomerService();
        public DiscoverProduct(CustomerHomePage customerHomePage, CustomerInfoResponse customer)
        {
            InitializeComponent();
            this.customerHomePage = customerHomePage;
            this.customer = customer;
        }
        IProductService productService = new ProductService(); 
        private void DiscoverProduct_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = productService.ActiveProductList();
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DiscoverProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (customerHomePage != null)
            {
                customerHomePage.Show();
            }
        }
        int id;
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dataGridView.SelectedRows.Count > 0)
                {
                    comboBox1.Items.Clear();
                    id = Convert.ToInt16(dataGridView.SelectedRows[0].Cells[0].Value);
                    ProductCategory.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                    ProductCode.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                    ProductName.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                    ProductVolume.Text = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                    ProductUnit.Text = dataGridView.SelectedRows[0].Cells[5].Value.ToString();
                    FName.Text = dataGridView.SelectedRows[0].Cells[6].Value.ToString(); 
                    Surname.Text = dataGridView.SelectedRows[0].Cells[7].Value.ToString();
                    Email.Text = dataGridView.SelectedRows[0].Cells[8].Value.ToString();
                    City.Text = dataGridView.SelectedRows[0].Cells[9].Value.ToString();
                    int stocknumber= Convert.ToInt16(dataGridView.SelectedRows[0].Cells[10].Value);
                    decimal cost= Convert.ToInt16(dataGridView.SelectedRows[0].Cells[11].Value);
                    pictureBox.ImageLocation = dataGridView.SelectedRows[0].Cells[12].Value.ToString();
                    for(int i = 1; i <= stocknumber; i++)
                    {
                        comboBox1.Items.Add(i);
                    }
                    comboBox1.SelectedIndex = 0;
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductCost.Text = productService.CalculateCost(new Contracts.Request.Product.CalculateCostRequest(id, Convert.ToInt16(comboBox1.Text))).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            id = 0;
            FName.Clear();
            Surname.Clear();
            Email.Clear();
            City.Clear();
            ProductCategory.Clear();
            ProductCode.Clear();
            ProductName.Clear();
            ProductVolume.Clear();
            ProductUnit.Clear();
            comboBox1.Items.Clear();
            ProductCost.Clear();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text != null || tbSearch.Text != "")
            {
                clearfilter.Visible = true;
            }
            if (tbSearch.Text == "")
            {
                clearfilter.Visible = false;
            }
            dataGridView.DataSource = productService.SearchProduct(new Contracts.Request.Product.SearchProductRequest(tbSearch.Text));
        }

        private void clearfilter_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
            clearfilter.Visible = false;
            dataGridView.DataSource = productService.ActiveProductList();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                {
                    ShowAutoClosingMessageBox("Please,select a product!", "Error");
                }
                else
                {
                    customerService.AddShoppingList(new Contracts.Request.ShoppingBasket.AddShoppingBasketRequest(customer.CustomerID, id, Convert.ToInt16(comboBox1.Text), Convert.ToDecimal(ProductCost.Text)));
                    ShowAutoClosingMessageBox("You can visit your shopping box to buy", "Succesfully Added");
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

        public void ShowAutoClosingMessageBox(string message, string caption)
        {
            var timer = new System.Timers.Timer(2000) { AutoReset = false };
            timer.Elapsed += delegate
            {
                IntPtr hWnd = FindWindowByCaption(IntPtr.Zero, caption);
                if (hWnd.ToInt32() != 0) PostMessage(hWnd, WM_CLOSE, 0, 0);
            };
            timer.Enabled = true;
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

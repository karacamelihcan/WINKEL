using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winkel.Contracts.Response.Customer;
using Winkel.Contracts.Response.Seller;
using Winkel.Services;

namespace Winkel
{
    public partial class PastOperations : Form
    {
        private SellerHomePage sellerHomePage;
        private SellerInformationResponse seller;
        private ISellerService sellerService = new SellerService();
        private CustomerHomePage customerHomePage;
        private ICustomerService customerService = new CustomerService();
        private CustomerInfoResponse customer;
        public PastOperations(SellerHomePage sellerHomePage, SellerInformationResponse seller)
        {
            InitializeComponent();
            this.sellerHomePage = sellerHomePage;
            this.seller = seller;
        }
        public PastOperations(CustomerHomePage customerHomePage,CustomerInfoResponse customer)
        {
            InitializeComponent();
            this.customerHomePage = customerHomePage;
            this.customer = customer;
        }
        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PastOperations_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sellerHomePage == null)
            {
                customerHomePage.Show();
            }
            else
            {
                sellerHomePage.Show();
            }
        }

        private void PastOperations_Load(object sender, EventArgs e)
        {
            if (seller != null)
            {
                dataGridView.DataSource = sellerService.PastOperations(new Contracts.Request.Seller.SellerPastOperationRequest(seller.SellerID));
            }
            else
            {
                dataGridView.DataSource = customerService.PastOperations(new Contracts.Request.Customer.CustomerPastOperationRequest(customer.CustomerID));
                lblName.Text = "Seller Name";
                lblSurname.Text = "Seller Surname";
                lblEmail.Text = "Seller Email";
                label4.Text = "Seller City";
            }
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dataGridView.SelectedRows.Count > 0)
                {
                    FName.Text= dataGridView.SelectedRows[0].Cells[1].Value.ToString(); ;
                    Surname.Text= dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                    Email.Text= dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                    City.Text= dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                    ProductCategory.Text= dataGridView.SelectedRows[0].Cells[5].Value.ToString();
                    ProductCode.Text= dataGridView.SelectedRows[0].Cells[6].Value.ToString();
                    ProductName.Text= dataGridView.SelectedRows[0].Cells[7].Value.ToString();
                    ProductVolume.Text= dataGridView.SelectedRows[0].Cells[8].Value.ToString();
                    ProductUnit.Text= dataGridView.SelectedRows[0].Cells[9].Value.ToString();
                    SalesNumber.Text= dataGridView.SelectedRows[0].Cells[10].Value.ToString();
                    ProductCost.Text= dataGridView.SelectedRows[0].Cells[11].Value.ToString();
                    pictureBox.ImageLocation= dataGridView.SelectedRows[0].Cells[12].Value.ToString();
                    //string email = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                    //string password = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                    //string city = dataGridView.SelectedRows[0].Cells[5].Value.ToString();
                    //string photo = dataGridView.SelectedRows[0].Cells[6].Value.ToString();
                    //tbID.Text = cID.ToString();
                    //tbName.Text = fname;
                    //tbSurname.Text = lname;
                    //tbEmail.Text = email;
                    //tbPassword.Text = password;
                    //comboBox1.Text = city;
                    //tbPhoto.Text = photo;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

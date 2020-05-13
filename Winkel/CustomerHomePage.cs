using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winkel.Services;

namespace Winkel
{
    public partial class CustomerHomePage : Form
    {
        private MainLogIN mainLogIN;
 
        private ICustomerService customerService = new CustomerService();
        private string Email;
        private string Password;

        public CustomerHomePage(MainLogIN mainLogIN,string Email,string Password)
        {
            InitializeComponent();
            this.mainLogIN = mainLogIN;
            this.Email = Email;
            this.Password = Password;
        }

     

        private void CustomerHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainLogIN != null)
            {
                mainLogIN.Show();
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to exit the application?", "Winkel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CustomerHomePage_Load(object sender, EventArgs e)
        {
            CustomerInfo.Text = customerService.GetCustomerNameSurname(new Contracts.Request.Customer.GetCustomerNameSurname(Email, Password));
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            var cust = customerService.GetCustomerInfo(new Contracts.Request.Customer.GetCustomerID(Email,Password));
            ProfilSettings profilSettings = new ProfilSettings(this,customerService, cust);
            this.Hide();
            profilSettings.Show();
        }

        private void PastOperationbtn_Click(object sender, EventArgs e)
        {
            var cust = customerService.GetCustomerInfo(new Contracts.Request.Customer.GetCustomerID(Email, Password));
            PastOperations pastOperations = new PastOperations(this, cust);
            this.Hide();
            pastOperations.Show();
        }

        private void DiscoverProductBtn_Click(object sender, EventArgs e)
        {
            var cust = customerService.GetCustomerInfo(new Contracts.Request.Customer.GetCustomerID(Email, Password));
            DiscoverProduct discoverProduct = new DiscoverProduct(this, cust);
            this.Hide();
            discoverProduct.Show();
        }

        private void ShoppingListBtn_Click(object sender, EventArgs e)
        {
            var cust = customerService.GetCustomerInfo(new Contracts.Request.Customer.GetCustomerID(Email, Password));
            ShoppingList shoppingList = new ShoppingList(cust);
            shoppingList.Show();
        }
    }
}

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
    public partial class SellerHomePage : Form
    {
        private MainLogIN mainLogIN;
        private string email;
        private string password;
        private ISellerService sellerService = new SellerService();
        
        public SellerHomePage(MainLogIN mainLogIN, string email, string password)
        {
            InitializeComponent();
            this.mainLogIN = mainLogIN;
            this.email = email;
            this.password = password;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you want to exit the application?", "Winkel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void SellerHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainLogIN != null)
            {
                mainLogIN.Show();
            }
        }

        private void SellerHomePage_Load(object sender, EventArgs e)
        {
            SellerInfo.Text = sellerService.GetSellerNameSurname(new Contracts.Request.Seller.GetSellerNameSurname(email, password));
            
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            var seller = sellerService.GetSellerInfo(new Contracts.Request.Seller.GetSellerID(email, password));
            ProfilSettings profilSettings = new ProfilSettings(this, sellerService, seller);
            this.Hide();
            profilSettings.Show();
        }

        private void PastOperationbtn_Click(object sender, EventArgs e)
        {
            var seller = sellerService.GetSellerInfo(new Contracts.Request.Seller.GetSellerID(email, password));
            PastOperations pastOperations = new PastOperations(this, seller);
            this.Hide();
            pastOperations.Show();
        }

        private void NotfBtn_Click(object sender, EventArgs e)
        {
            var seller = sellerService.GetSellerInfo(new Contracts.Request.Seller.GetSellerID(email, password));
            NotificationScreen notificationScreen = new NotificationScreen(seller);
            notificationScreen.Show();
            
        }

        private void ProductManagementBtn_Click(object sender, EventArgs e)
        {
            var seller = sellerService.GetSellerInfo(new Contracts.Request.Seller.GetSellerID(email, password));
            ProductSettingScreen productSetting = new ProductSettingScreen(this, seller);
            this.Hide();
            productSetting.Show();
        }
    }
}

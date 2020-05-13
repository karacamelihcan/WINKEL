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
using Winkel.Contracts.Response.Seller;
using Winkel.Services;

namespace Winkel
{
    public partial class ProfilSettings : Form
    {
        private SellerHomePage sellerHomePage;
        private ISellerService sellerService;
        private SellerInformationResponse seller;
        private CustomerHomePage customerHomePage;
        private ICustomerService customerService;
        private CustomerInfoResponse customer;

        public ProfilSettings(SellerHomePage sellerHomePage, ISellerService sellerService, SellerInformationResponse seller)
        {
            InitializeComponent();
            this.sellerHomePage = sellerHomePage;
            this.sellerService = sellerService;
            this.seller = seller;
        }
        public ProfilSettings(CustomerHomePage customerHomePage, ICustomerService customerService, CustomerInfoResponse customer)
        {
            InitializeComponent();
            this.customerHomePage = customerHomePage;
            this.customerService = customerService;
            this.customer = customer;
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProfilSettings_FormClosed(object sender, FormClosedEventArgs e)
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

        private void ProfilSettings_Load(object sender, EventArgs e)
        {
            if (sellerService == null)
            {
                var list = customerService.CityList();
                CityList.DataSource = list;
                CityList.DisplayMember = "CityName";
                SName.Text = customer.Name;
                Surname.Text = customer.Surname;
                Email.Text = customer.Email;
                Password.Text = customer.Password;
                CityList.Text = customer.CityName;
                Photo.Text = customer.Photo;
                pictureBox.ImageLocation = customer.Photo;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                var list = sellerService.CityList();
                CityList.DataSource = list;
                CityList.DisplayMember = "CityName";
                SName.Text = seller.Name;
                Surname.Text = seller.Surname;
                Email.Text = seller.Email;
                Password.Text = seller.Password;
                CityList.Text = seller.CityName;
                Photo.Text = seller.Photo;
                pictureBox.ImageLocation = seller.Photo;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            int upper = 0, lower = 0, number = 0, special = 0;
            for (int i = 0; i < Password.Text.Length; i++)
            {
                char ch = Password.Text[i];
                if (ch >= 'A' && ch <= 'Z')
                    upper++;
                else if (ch >= 'a' && ch <= 'z')
                    lower++;
                else if (ch >= '0' && ch <= '9')
                    number++;
                else
                    special++;
            }
            int value = (Password.Text.Length + upper + lower + number + special) * 5;
            if (value < 100)
            {
                progressBar.Value = value;
            }
            else
            {
                progressBar.Value = 100;
            }

            if (progressBar.Value < 30)
            {
                lblPasswordStrong.Text = "Weak";
                lblPasswordStrong.ForeColor = Color.Red;
            }
            else
            {
                if (progressBar.Value >= 30 && progressBar.Value < 60)
                {
                    lblPasswordStrong.Text = "Medium";
                    lblPasswordStrong.ForeColor = Color.Yellow;
                }
                else
                {
                    lblPasswordStrong.Text = "Power";
                    lblPasswordStrong.ForeColor = Color.Green;
                }
            }
        }

        private void SeePassword_Click(object sender, EventArgs e)
        {
            if (Password.UseSystemPasswordChar == true)
            {
                Password.UseSystemPasswordChar = false;
                if (Password.Text == "Password")
                {
                    Password.Clear();
                    progressBar.Value = 0;
                    lblPasswordStrong.Text = "";
                }
            }
            else
                Password.UseSystemPasswordChar = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            SName.Text = "Name"; SName.ForeColor = Color.Silver;
            Surname.Text = "Surname"; Surname.ForeColor = Color.Silver;
            Email.Text = "Email"; Email.ForeColor = Color.Silver;
            Password.Text = "Password"; Password.ForeColor = Color.Silver;
            progressBar.Value = 0; lblPasswordStrong.Text = "";
            CityList.Text = "ADANA";
            Photo.Text = "Upload a file"; Photo.ForeColor = Color.Silver;
            pictureBox.Image = null;
            SName.Focus();
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            pictureBox.ImageLocation = openFileDialog.FileName;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Photo.Text = openFileDialog.FileName;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(Email.Text.Contains("@") && Email.Text.Contains(".com")))
                {
                    lblUyarı.Text = "Please, enter a correct email!";
                    lblUyarı.ForeColor = Color.Red;
                }
                else
                {
                    if ((SName.Text == "" || SName.Text == "Name") || (Surname.Text == "" || Surname.Text == "Surname") || (Email.Text == "" || Email.Text == "Email") || (Password.Text == "" || Password.Text == "Password") || (Photo.Text == "" || Photo.Text == "Upload a file"))
                    {
                        lblUyarı.Text = "All fields mark with (*) are mandatory !";
                    }
                    else
                    {
                        lblUyarı.Text = "";
                        if (sellerService == null)
                        {
                            if(MessageBox.Show("Are you sure you want to update your informations", "Winkel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                customerService.Update(new Contracts.Request.Customer.CustomerUpdateRequest(customer.CustomerID, SName.Text.ToUpper(), Surname.Text.ToUpper(), Email.Text, Password.Text, CityList.Text, Photo.Text));
                                ShowAutoClosingMessageBox("Your informations successfully updated ! ", "Registration Successfull !");
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Are you sure you want to update your informations", "Winkel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                ShowAutoClosingMessageBox("Your informations successfully updated ! ", "Registration Successfull !");
                            }
                            sellerService.Update(new Contracts.Request.Seller.SellerUpdateRequest(seller.SellerID,SName.Text.ToUpper(), Surname.Text.ToUpper(), Email.Text, Password.Text, CityList.Text, Photo.Text));
                           
                        }
                    }
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
            var timer = new System.Timers.Timer(5000) { AutoReset = false };
            timer.Elapsed += delegate
            {
                IntPtr hWnd = FindWindowByCaption(IntPtr.Zero, caption);
                if (hWnd.ToInt32() != 0) PostMessage(hWnd, WM_CLOSE, 0, 0);
            };
            timer.Enabled = true;
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SName_Click(object sender, EventArgs e)
        {
            SName.ForeColor = Color.Black;
            if (SName.Text == "Name")
            {
                SName.Clear();
            }
            if (Surname.Text == "")
            {
                Surname.Text = "Surname";
                Surname.ForeColor = Color.Silver;
            }
            if (Email.Text == "")
            {
                Email.Text = "Email";
                Email.ForeColor = Color.Silver;
            }
            if (Password.Text == "")
            {
                Password.Text = "Password";
                Password.ForeColor = Color.Silver;
                progressBar.Value = 0;
                lblPasswordStrong.Text = "";
            }
            if (Photo.Text == "")
            {
                Photo.Text = "Upload a file";
                Photo.ForeColor = Color.Silver;
            }
        }

        private void Surname_Click(object sender, EventArgs e)
        {
            Surname.ForeColor = Color.Black;
            if (Surname.Text == "Surname")
            {
                Surname.Clear();
            }
            if (SName.Text == "")
            {
                SName.Text = "Name";
                SName.ForeColor = Color.Silver;
            }
            if (Email.Text == "")
            {
                Email.Text = "Email";
                Email.ForeColor = Color.Silver;
            }
            if (Password.Text == "")
            {
                Password.Text = "Password";
                Password.ForeColor = Color.Silver;
                progressBar.Value = 0;
                lblPasswordStrong.Text = "";
            }
            if (Photo.Text == "")
            {
                Photo.Text = "Upload a file";
                Photo.ForeColor = Color.Silver;
            }
        }

        private void Email_Click(object sender, EventArgs e)
        {
            Email.ForeColor = Color.Black;
            if (Email.Text == "Email")
            {
                Email.Clear();
            }
            if (SName.Text == "")
            {
                SName.Text = "Name";
                SName.ForeColor = Color.Silver;
            }
            if (Surname.Text == "")
            {
                Surname.Text = "Surname";
                Surname.ForeColor = Color.Silver;
            }
            if (Password.Text == "")
            {
                Password.Text = "Password";
                Password.ForeColor = Color.Silver;
                progressBar.Value = 0;
                lblPasswordStrong.Text = "";
            }
            if (Photo.Text == "")
            {
                Photo.Text = "Upload a file";
                Photo.ForeColor = Color.Silver;
            }
        }

        private void Password_Click(object sender, EventArgs e)
        {
            Password.ForeColor = Color.Black;

            if (Password.Text == "Password")
            {
                Password.Clear();
                progressBar.Value = 0;
                lblPasswordStrong.Text = "";
            }
            if (SName.Text == "")
            {
                SName.Text = "Name";
                SName.ForeColor = Color.Silver;
            }
            if (Surname.Text == "")
            {
                Surname.Text = "Surname";
                Surname.ForeColor = Color.Silver;
            }
            if (Email.Text == "")
            {
                Email.Text = "Email";
                Email.ForeColor = Color.Silver;

            }
            if (Photo.Text == "")
            {
                Photo.Text = "Upload a file";
                Photo.ForeColor = Color.Silver;
            }
        }

        private void Photo_Click(object sender, EventArgs e)
        {
            Photo.ForeColor = Color.Black;

            if (Photo.Text == "Upload a file")
            {
                Photo.Clear();

            }
            if (SName.Text == "")
            {
                SName.Text = "Name";
                SName.ForeColor = Color.Silver;
            }
            if (Surname.Text == "")
            {
                Surname.Text = "Surname";
                Surname.ForeColor = Color.Silver;
            }
            if (Email.Text == "")
            {
                Email.Text = "Email";
                Email.ForeColor = Color.Silver;

            }
            if (Password.Text == "")
            {
                Password.Text = "Password";
                Password.ForeColor = Color.Silver;
                progressBar.Value = 0;
                lblPasswordStrong.Text = "";
            }
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            Email.ForeColor = Color.Black;
            if (Email.Text != "Email")
            {
                if (!(Email.Text.Contains("@") && Email.Text.Contains(".com")))
                {
                    lblUyarı.Text = "Please, enter a correct email!";
                    lblUyarı.ForeColor = Color.Red;
                }
                else
                {
                    lblUyarı.Text = "";
                }
            }
            else
            {
                lblUyarı.Text = "";
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if(sellerService == null)
            {
                if(MessageBox.Show("Your can't undo your action. Are you sure you want to delete your account ?","Winkel",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    customerService.Delete(new Contracts.Request.Customer.CustomerDeleteRequest(customer.CustomerID));
                    Application.Restart();

                }
            }
            else
            {
                if (MessageBox.Show("Your can't undo your action. Are you sure you want to delete your account ?", "Winkel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sellerService.Delete(new Contracts.Request.Seller.SellerDeleteRequest(seller.SellerID));
                    Application.Restart();
                }
            }
        }
    }
}

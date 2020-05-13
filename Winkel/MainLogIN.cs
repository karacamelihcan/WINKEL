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
using Winkel.Services;
namespace Winkel
{
    public partial class MainLogIN : Form
    {
        public MainLogIN()
        {
            InitializeComponent();
        }

        readonly ISellerService sellerService = new SellerService();
        readonly ICustomerService customerService = new CustomerService();
        
        private void sellerEmail_Click(object sender, EventArgs e)
        {
            if (sellerEmail.Text == "Email")
                sellerEmail.Text = "";
            if (sellerPassword.Text == "")
            { sellerPassword.Text = "Password..."; sellerPassword.ForeColor = Color.Silver; }
            if (customerEmail.Text == "")
            { customerEmail.Text = "Email"; customerEmail.ForeColor = Color.Silver; }
            if (customerPassword.Text == "")
            { customerPassword.Text = "Password..."; customerPassword.ForeColor = Color.Silver; }

        }

        private void customerEmail_Click(object sender, EventArgs e)
        {
            if (customerEmail.Text == "Email")
                customerEmail.Text = "";
            if (sellerEmail.Text == "")
            { sellerEmail.Text = "Email"; sellerEmail.ForeColor = Color.Silver; }
            if (sellerPassword.Text == "")
            { sellerPassword.Text = "Password..."; sellerPassword.ForeColor = Color.Silver; }
            if (customerPassword.Text == "")
            { customerPassword.Text = "Password..."; customerPassword.ForeColor = Color.Silver; }
        }

        private void sellerPassword_Click(object sender, EventArgs e)
        {
            if (sellerPassword.Text == "Password...")
                sellerPassword.Text = "";
            if (sellerEmail.Text == "")
            { sellerEmail.Text = "Email"; sellerEmail.ForeColor = Color.Silver; }
            if (customerEmail.Text == "")
            { customerEmail.Text = "Email"; customerEmail.ForeColor = Color.Silver; }
            if (customerPassword.Text == "")
            { customerPassword.Text = "Password..."; customerPassword.ForeColor = Color.Silver; }
        }

        private void customerPassword_Click(object sender, EventArgs e)
        {
            if (customerPassword.Text == "Password...")
                customerPassword.Text = "";
            if (sellerEmail.Text == "")
            { sellerEmail.Text = "Email"; sellerEmail.ForeColor = Color.Silver; }
            if (customerEmail.Text == "")
            { customerEmail.Text = "Email"; customerEmail.ForeColor = Color.Silver; }
            if (sellerPassword.Text == "")
            { sellerPassword.Text = "Password..."; sellerPassword.ForeColor = Color.Silver; }
        }

        private void sellerEmail_TextChanged(object sender, EventArgs e)
        {
            sellerEmail.ForeColor = Color.Black;
            if (sellerEmail.Text != "Email")
            {
                if (!(sellerEmail.Text.Contains("@") && sellerEmail.Text.Contains(".com")))
                {
                    lblSellerEmail.Text = "Please, enter a correct email!";
                    lblSellerEmail.ForeColor = Color.Red;
                }
                else
                {
                    lblSellerEmail.Text = "";
                }
            }
            else
            {
                lblSellerEmail.Text = "";
            }
        }

        private void customerEmail_TextChanged(object sender, EventArgs e)
        {
            customerEmail.ForeColor = Color.Black;
            if (customerEmail.Text != "Email")
            {
                if (!(customerEmail.Text.Contains("@") && customerEmail.Text.Contains(".com")))
                {
                    lblCustomerEmail.Text = "Please, enter a correct email!";
                    lblCustomerEmail.ForeColor = Color.Red;
                }
                else
                {
                    lblCustomerEmail.Text = "";
                }
            }
            else
            {
                lblCustomerEmail.Text = "";
            }
        }
        private void sellerPassword_TextChanged(object sender, EventArgs e)
        {
            sellerPassword.ForeColor = Color.Black;
        }

        private void customerPassword_TextChanged(object sender, EventArgs e)
        {
            customerPassword.ForeColor = Color.Black;
        }
        private void SellerLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if(!(sellerEmail.Text.Contains("@") && sellerEmail.Text.Contains(".com")))
                {
                    MessageBox.Show("Please,enter a correct email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (sellerPassword.Text == "")
                    {
                        MessageBox.Show("Please,enter a correct password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (sellerService.LogIn(new Contracts.Request.Seller.SellerLogInRequest(sellerEmail.Text, sellerPassword.Text)))
                        {

                            ShowAutoClosingMessageBox("Log In successfull! ", "Successfull");
                            
                            SellerHomePage sellerHomePage = new SellerHomePage(this, sellerEmail.Text, sellerPassword.Text);
                            clear();
                            this.Hide();
                            sellerHomePage.Show();

                        }
                        else
                        {
                            MessageBox.Show("Incorrect email or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CustomerLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(customerEmail.Text.Contains("@") && customerEmail.Text.Contains(".com")))
                {
                    MessageBox.Show("Please,enter a correct email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (customerPassword.Text == "")
                    {
                        MessageBox.Show("Please,enter a correct password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (customerService.LogIn(new Contracts.Request.Customer.CustomerLogInRequest(customerEmail.Text,customerPassword.Text)))
                        {

                            ShowAutoClosingMessageBox("Log In successfull! ", "Successfull");
                            
                            CustomerHomePage customerHomePage = new CustomerHomePage(this, customerEmail.Text, customerPassword.Text);
                            this.Hide();
                            clear();
                            customerHomePage.Show();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect email or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var timer = new System.Timers.Timer(2000) { AutoReset = false };
            timer.Elapsed += delegate
            {
                IntPtr hWnd = FindWindowByCaption(IntPtr.Zero, caption);
                if (hWnd.ToInt32() != 0) PostMessage(hWnd, WM_CLOSE, 0, 0);
            };
            timer.Enabled = true;
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void clear()
        {
            sellerEmail.Text = "Email";sellerEmail.ForeColor = Color.Silver;
            sellerPassword.Text = "Password...";sellerPassword.ForeColor = Color.Silver;
            customerEmail.Text = "Email";customerEmail.ForeColor = Color.Silver;
            customerPassword.Text = "Password...";customerPassword.ForeColor = Color.Silver;
        }

        private void SellerRegisterbtn_Click(object sender, EventArgs e)
        {
            clear();
            NewRegister sellerRegister = new NewRegister(this,sellerService);
            sellerRegister.Show();
            this.Hide();
        }

        private void slrforgot_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword(this, sellerService);
            forgotPassword.Show();
            this.Hide();
        }

        private void CustomerRegister_Click(object sender, EventArgs e)
        {
            clear();
            NewRegister customerRegister = new NewRegister(this, customerService);
            customerRegister.Show();
            this.Hide();
        }

        private void cstforgot_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword(this, customerService);
            forgotPassword.Show();
            this.Hide();
        }
    }
}

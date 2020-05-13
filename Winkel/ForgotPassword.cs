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
    public partial class ForgotPassword : Form
    {
        private MainLogIN mainLogIN;
        private ISellerService sellerService;
        private ICustomerService customerService;

        public ForgotPassword(MainLogIN mainLogIN, ISellerService sellerService)
        {
            InitializeComponent();
            this.mainLogIN = mainLogIN;
            this.sellerService = sellerService;
        }
        public ForgotPassword(MainLogIN mainLogIN, ICustomerService customerService)
        {
            InitializeComponent();
            this.mainLogIN = mainLogIN;
            this.customerService = customerService;
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            if (mainLogIN != null)
            {
                this.Close();
                mainLogIN.Show();
            }
            
        }

        private void ForgotPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainLogIN != null)
            {
                mainLogIN.Show();
            }
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            Email.ForeColor = Color.Black;
            if (Email.Text != "Email")
            {
                if (!(Email.Text.Contains("@") && Email.Text.Contains(".com")))
                {
                    label1.Text = "Please, enter a correct email!";
                    label1.ForeColor = Color.Red;
                }
                else
                {
                    label1.Text = "";
                }
            }
            else
            {
                label1.Text = "";
            }
        }

        private void sendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                if (Email.Text == "" || Email.Text == "Email")
                {
                    label1.Text = "Please, enter an email !";
                }
                else
                {
                    if (!(Email.Text.Contains("@") && Email.Text.Contains(".com")))
                    {
                        label1.Text = "Please, enter a correct email!";
                        label1.ForeColor = Color.Red;
                    }
                    else
                    {
                        if (sellerService == null)
                        {
                            if (customerService.CheckEmail(new Contracts.Request.Customer.CustomerCheckEmailRequest(Email.Text)))
                            {
                                label1.Text = "We did not find any registered users with this email";
                            }
                            else
                            {
                                if (customerService.ForgotPassword(new Contracts.Request.Customer.ForgotPasswordRequest(Email.Text)))
                                {
                                    ShowAutoClosingMessageBoxInfo("We send your password to " + Email.Text, "Successfull");
                                }
                                else
                                {
                                    ShowAutoClosingMessageBoxError("Error", "Error");
                                }
                            }
                        }
                        else
                        {
                            if(sellerService.CheckEmail(new Contracts.Request.Seller.SellerCheckEmailRequest(Email.Text)))
                            {
                                label1.Text = "We did not find any registered users with this email";
                            }
                            else
                            {
                                if(sellerService.ForgotPassword(new Contracts.Request.Seller.ForgotPasswordRequest(Email.Text))) 
                                { 
                                    ShowAutoClosingMessageBoxInfo("We send your password to "+Email.Text,"Successfull");
                                }
                                else
                                {
                                    ShowAutoClosingMessageBoxError("Error", "Error");
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
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        [DllImport("user32.Dll")]
        static extern int PostMessage(IntPtr hWnd, UInt32 msg, int wParam, int lParam);

        private const UInt32 WM_CLOSE = 0x0010;

        public void ShowAutoClosingMessageBoxInfo(string message, string caption)
        {
            var timer = new System.Timers.Timer(3000) { AutoReset = false };
            timer.Elapsed += delegate
            {
                IntPtr hWnd = FindWindowByCaption(IntPtr.Zero, caption);
                if (hWnd.ToInt32() != 0) PostMessage(hWnd, WM_CLOSE, 0, 0);
            };
            timer.Enabled = true;
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ShowAutoClosingMessageBoxError(string message, string caption)
        {
            var timer = new System.Timers.Timer(5000) { AutoReset = false };
            timer.Elapsed += delegate
            {
                IntPtr hWnd = FindWindowByCaption(IntPtr.Zero, caption);
                if (hWnd.ToInt32() != 0) PostMessage(hWnd, WM_CLOSE, 0, 0);
            };
            timer.Enabled = true;
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}

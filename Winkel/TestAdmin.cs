using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinkelDAL.Model;
using Winkel.Services;

namespace Winkel
{
    public partial class TestAdmin : Form
    {

        public TestAdmin()
        {
            InitializeComponent();
        }
        AdminServices adminServices = new AdminServices();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbName.Text != "" && tbSurname.Text != "" && tbEmail.Text != "" && tbPassword.Text != "")
                {
                    Admin admin = new Admin();
                    admin.Name = tbName.Text.ToUpper();
                    admin.Surname = tbSurname.Text.ToUpper();
                    admin.Email = tbEmail.Text;
                    admin.Password = tbPassword.Text;
                    adminServices.Register(admin);
                    MessageBox.Show("Kayıt Başarılı");
                }
                else
                    MessageBox.Show("Gerekli alanları doldudurun");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbEmail.Text != "" && tbPassword.Text != "")
                {
                    Admin admin = new Admin();
                    admin.Email = tbEmail.Text;
                    admin.Password = tbPassword.Text;
                    if (adminServices.LogIn(admin))
                    {
                        lblLogin.Text = "Log in is successfull!";
                        lblLogin.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblLogin.Text = "Log is unsuccessfull!";
                        lblLogin.ForeColor = Color.Red;
                    }

                }
                else
                    MessageBox.Show("Gerekli alanları doldudurun");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

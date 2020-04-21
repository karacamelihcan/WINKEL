using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinkelDAL.Context;
using WinkelDAL.Model;
using Winkel.Services;
namespace Winkel
{
    public partial class TestCustomer : Form
    {
        public TestCustomer()
        {
            InitializeComponent();
        }
        ICustomerService customerService = new CustomerService();
        ICityService cityService = new CityService();
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                dataGridView1.DataSource = customerService.GetCustomer();   
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dataGridView1.SelectedRows.Count > 0)
                {
                    int cID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    string fname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    string lname = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    string email = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    string password = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    string city = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    string photo = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

                    tbID.Text = cID.ToString();
                    tbName.Text = fname;
                    tbSurname.Text = lname;
                    tbEmail.Text = email;
                    tbPassword.Text = password;
                    comboBox1.Text = city;
                    tbPhoto.Text = photo;
                }
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
                Customer customer = new Customer();
                customer.Name = tbName.Text.ToUpper();
                customer.Surname = tbSurname.Text.ToUpper();
                customer.Email = tbEmail.Text;
                customer.Password = tbPassword.Text;
                customer.CityID = cityService.GetCityID(comboBox1.Text);
                customer.Photo = tbPhoto.Text;
                customerService.Register(customer);
                dataGridView1.DataSource = customerService.GetCustomer();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();
                ICityService cityService = new CityService();
                customer.Email = tbEmail.Text;
                customer.Password = tbPassword.Text;
                if (customerService.LogIn(customer))
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void TestCustomer_Load(object sender, EventArgs e)
        {
            ICityService cityService = new CityService();
            var citylist = cityService.CityList();
            comboBox1.DataSource = citylist;
            comboBox1.DisplayMember = "CityName";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbID.Text!="")
                {
                    Customer customer = new Customer();
                    customer.CustomerID = Convert.ToInt16(tbID.Text);
                    if (customerService.Delete(customer))
                    {
                        MessageBox.Show("Silme işlemi başarılı");
                        dataGridView1.DataSource = customerService.GetCustomer();
                    }
                    else
                        MessageBox.Show("Böyle bir kayıt bulunmamaktadır");

                }
                else
                    MessageBox.Show("Lütfen bir kayıt seçin");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        
        
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbID.Text != "")
                {
                    Customer customer = new Customer();
                    customer.CustomerID = Convert.ToInt16(tbID.Text);
                    customer.Name = tbName.Text.ToUpper();
                    customer.Surname = tbSurname.Text.ToUpper();
                    customer.Email = tbEmail.Text;
                    customer.Password = tbPassword.Text;
                    customer.CityID = cityService.GetCityID(comboBox1.Text);
                    customer.Photo = tbPhoto.Text;
                    if (customerService.Update(customer)) 
                    { 
                        MessageBox.Show("Güncelleme başarılı");
                        dataGridView1.DataSource = customerService.GetCustomer(); 
                    }
                else
                    MessageBox.Show("Böyle bir kayıt bulunmamaktadır");
                }
                else
                    MessageBox.Show("Lütfen bir kayıt seçin");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = customerService.SearchCustomer(tbSearch.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbID.Text != "")
                {
                    Customer customer = new Customer();
                    customer.CustomerID = Convert.ToInt16(tbID.Text);
                    dataGridView1.DataSource= customerService.PastOperations(customer);
                }
                else
                    MessageBox.Show("Lütfen bir kayıt seçin");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

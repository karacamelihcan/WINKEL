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
using WinkelDAL.Model;

namespace Winkel
{
    public partial class TestCity : Form
    {
        public TestCity()
        {
            InitializeComponent();
        }

        private void TestCity_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ICityService city = new CityService();
            dataGridView1.DataSource = city.CityList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ICityService cityService = new CityService();
                lblCityId.Text = cityService.GetCityID(tbCityName.Text).ToString();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

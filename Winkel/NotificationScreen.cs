using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winkel.Contracts.Response.Seller;
using Winkel.Services;

namespace Winkel
{
    public partial class NotificationScreen : Form
    {
        private SellerInformationResponse seller;
        private ISellerService sellerService = new SellerService();
        public NotificationScreen(SellerInformationResponse seller)
        {
            InitializeComponent();
            this.seller = seller;
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            if (seller != null)
            {
                dataGridView.DataSource = sellerService.NotificationList(new Contracts.Request.Notification.SellerNotificationRequest(seller.SellerID));
            }
        }
        public int ID;
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dataGridView.SelectedRows.Count > 0)
                {
                    ID = int.Parse(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID!=0)
                {
                    sellerService.ReadNotification(new Contracts.Request.Notification.ReadNotificationRequest(ID));
                    dataGridView.DataSource = sellerService.NotificationList(new Contracts.Request.Notification.SellerNotificationRequest(seller.SellerID));
                }
                else
                {
                    MessageBox.Show("Lütfen bir mesaj seçin");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void SellerLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {
                    sellerService.UnReadNotification(new Contracts.Request.Notification.UnReadNotificationRequest(ID));
                    dataGridView.DataSource = sellerService.NotificationList(new Contracts.Request.Notification.SellerNotificationRequest(seller.SellerID));
                }
                else
                {
                    MessageBox.Show("Lütfen bir mesaj seçin");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dataGridView.Rows)
            {            
                if (Myrow.Cells[12].Value.ToString() == "READ")
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Silver;
                }
              
            }
        }
    }
}

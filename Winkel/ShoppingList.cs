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
using Winkel.Services;

namespace Winkel
{
    public partial class ShoppingList : Form
    {
        private CustomerInfoResponse cust;
        ICustomerService customerService = new CustomerService();

        public ShoppingList(CustomerInfoResponse cust)
        {
            InitializeComponent();
            this.cust = cust;
        }

        private void ShoppingList_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = customerService.ShoppingList(new Contracts.Request.ShoppingBasket.ShoppingListRequest(cust.CustomerID));
        }

        private void ClearAllProductBtn_Click(object sender, EventArgs e)
        {
            customerService.ClearAllShoppingList(new Contracts.Request.ShoppingBasket.ClearAllShoppingList(cust.CustomerID));
            dataGridView.DataSource = customerService.ShoppingList(new Contracts.Request.ShoppingBasket.ShoppingListRequest(cust.CustomerID));
            ShowAutoClosingMessageBox("Your shopping list successfully cleared!", "Successfully Clear");
        }
        int id;
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dataGridView.SelectedRows.Count > 0)
                {
                   
                    id = Convert.ToInt16(dataGridView.SelectedRows[0].Cells[0].Value);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {
                    customerService.ClearShoppingBasket(new Contracts.Request.ShoppingBasket.ClearShoppingListRequest(id));
                    dataGridView.DataSource = customerService.ShoppingList(new Contracts.Request.ShoppingBasket.ShoppingListRequest(cust.CustomerID));
                    ShowAutoClosingMessageBox("This Product removed from your shopping list", "Successfully Clear");
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
                int value = dataGridView.Rows.Count;
                if (dataGridView.Rows.Count != 0)
                {
                    customerService.AddSales(new Contracts.Request.ShoppingBasket.AddShoppingBasketRequest(cust.CustomerID));
                    dataGridView.DataSource = customerService.ShoppingList(new Contracts.Request.ShoppingBasket.ShoppingListRequest(cust.CustomerID));
                    ShowAutoClosingMessageBoxInfo("Enjoy It!", "Successfully Bought");
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
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void ShowAutoClosingMessageBoxInfo(string message, string caption)
        {
            var timer = new System.Timers.Timer(2000) { AutoReset = false };
            timer.Elapsed += delegate
            {
                IntPtr hWnd = FindWindowByCaption(IntPtr.Zero, caption);
                if (hWnd.ToInt32() != 0) PostMessage(hWnd, WM_CLOSE, 0, 0);
            };
            timer.Enabled = true;
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

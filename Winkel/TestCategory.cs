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
    public partial class TestCategory : Form
    {
        public TestCategory()
        {
            InitializeComponent();
        }
        ICategoryService categoryService = new CategoryService();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = categoryService.CategoryList();
        }

        private void TestCategory_Load(object sender, EventArgs e)
        {
            var categoryList = categoryService.CategoryList();
            comboBox1.DataSource = categoryList;
            comboBox1.DisplayMember = "CategoryName";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblCategory.Text = categoryService.GetCategoryID(comboBox1.Text).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = tbCategory.Text.Trim();

            categoryService.AddCategory(category);
            lblCategory.Text = categoryService.GetCategoryID(comboBox1.Text).ToString();
            var categoryList = categoryService.CategoryList();
            comboBox1.DataSource = categoryList;
            comboBox1.DisplayMember = "CategoryName";
        }
    }
}

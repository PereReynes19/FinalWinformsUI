using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsUI_Project1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
            {
                string catsql = "SELECT name FROM Production.ProductCategory;";
                List<string> categories = new List<string>();
                categories = connection.Query<string>(catsql).ToList();
                foreach (string category in categories)
                {
                    categoryComboBox.Items.Add(category);
                }

                string subsql = "SELECT name FROM Production.ProductSubcategory;";
                List<string> subcategories = new List<string>();
                subcategories = connection.Query<string>(subsql).ToList();
                foreach (string subcategory in subcategories)
                {
                    subCategoryComboBox.Items.Add(subcategory);
                }
            }
        }
    }
}

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
        private List<ProductModel> productModels;
        public void SelectCategory()
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
            }
        }
        public void SelectSubCategory()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
            {
                string subsql = $"SELECT Production.ProductSubcategory.Name FROM Production.ProductSubcategory INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID WHERE Production.ProductCategory.Name = '{categoryComboBox.SelectedItem}' ;";
                List<string> subcategories = new List<string>();
                subcategories = connection.Query<string>(subsql).ToList();
                foreach (string subcategory in subcategories)
                {
                    subCategoryComboBox.Items.Add(subcategory);
                }
            }
        }
        public void addCatListView()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
            {
                productModels = new List<ProductModel>();
                string addCatSQL = $"SELECT Production.ProductModel.Name, Production.ProductDescription.Description FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID INNER JOIN Production.ProductDescription ON Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID WHERE Production.ProductModelProductDescriptionCulture.CultureID = 'en' AND Production.ProductCategory.Name = '{categoryComboBox.SelectedItem}' AND Product.ProductModelID IS NOT NULL";
                productModels = connection.Query<ProductModel>(addCatSQL).ToList();
                resultListView.Items.Clear();
                foreach (ProductModel productModel in productModels)
                {
                    resultListView.Items.Add(productModel.ToString());  
                }       
            }
        }
        public void addSubListView()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
            {
                productModels = new List<ProductModel>();
                string addSubSQL = $"SELECT Production.ProductModel.Name, Production.ProductDescription.Description FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID INNER JOIN Production.ProductDescription ON Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID WHERE Production.ProductModelProductDescriptionCulture.CultureID = 'en' AND Production.ProductSubcategory.Name = '{subCategoryComboBox.SelectedItem}' AND Product.ProductModelID IS NOT NULL";
                productModels = connection.Query<ProductModel>(addSubSQL).ToList();
                resultListView.Items.Clear();
                foreach (ProductModel productModel in productModels)
                {
                    resultListView.Items.Add(productModel.ToString());
                }
            }
        }
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            SelectCategory();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectSubCategory();
            addCatListView();
        }

        private void subCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addSubListView();
        }
    }
}

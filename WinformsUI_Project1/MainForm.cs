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
<<<<<<< HEAD
                subCategoryComboBox.Items.Clear();
=======
>>>>>>> faa1180141c4e4c54ee49aadd8a4fa6db1bbef73
                foreach (string subcategory in subcategories)
                {
                    subCategoryComboBox.Items.Add(subcategory);
                }
            }
        }
<<<<<<< HEAD
        public void AddCatListView()
=======
        public void addCatListView()
>>>>>>> faa1180141c4e4c54ee49aadd8a4fa6db1bbef73
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
            {
                productModels = new List<ProductModel>();
<<<<<<< HEAD
                string addCatSQL = $"SELECT DISTINCT Production.ProductModel.Name, Production.ProductDescription.Description FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID INNER JOIN Production.ProductDescription ON Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID WHERE Production.ProductModelProductDescriptionCulture.CultureID = 'en' AND Production.ProductCategory.Name = '{categoryComboBox.SelectedItem}' AND Product.ProductModelID IS NOT NULL";
=======
                string addCatSQL = $"SELECT Production.ProductModel.Name, Production.ProductDescription.Description FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID INNER JOIN Production.ProductDescription ON Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID WHERE Production.ProductModelProductDescriptionCulture.CultureID = 'en' AND Production.ProductCategory.Name = '{categoryComboBox.SelectedItem}' AND Product.ProductModelID IS NOT NULL";
>>>>>>> faa1180141c4e4c54ee49aadd8a4fa6db1bbef73
                productModels = connection.Query<ProductModel>(addCatSQL).ToList();
                resultListView.Items.Clear();
                foreach (ProductModel productModel in productModels)
                {
                    resultListView.Items.Add(productModel.ToString());  
                }       
            }
        }
<<<<<<< HEAD
        public void AddSubListView()
=======
        public void addSubListView()
>>>>>>> faa1180141c4e4c54ee49aadd8a4fa6db1bbef73
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
            {
                productModels = new List<ProductModel>();
<<<<<<< HEAD
                string addSubSQL = $"SELECT DISTINCT Production.ProductModel.Name, Production.ProductDescription.Description FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID INNER JOIN Production.ProductDescription ON Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID WHERE Production.ProductModelProductDescriptionCulture.CultureID = 'en' AND Production.ProductSubcategory.Name = '{subCategoryComboBox.SelectedItem}' AND Product.ProductModelID IS NOT NULL";
=======
                string addSubSQL = $"SELECT Production.ProductModel.Name, Production.ProductDescription.Description FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID INNER JOIN Production.ProductDescription ON Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID WHERE Production.ProductModelProductDescriptionCulture.CultureID = 'en' AND Production.ProductSubcategory.Name = '{subCategoryComboBox.SelectedItem}' AND Product.ProductModelID IS NOT NULL";
>>>>>>> faa1180141c4e4c54ee49aadd8a4fa6db1bbef73
                productModels = connection.Query<ProductModel>(addSubSQL).ToList();
                resultListView.Items.Clear();
                foreach (ProductModel productModel in productModels)
                {
                    resultListView.Items.Add(productModel.ToString());
                }
            }
        }
<<<<<<< HEAD

        public void SelectStyle()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
            {
                string styleSql = $"SELECT DISTINCT Production.Product.Style FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID  INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID WHERE ProductModelProductDescriptionCulture.CultureID = 'en'AND Production.ProductSubcategory.Name = '{subCategoryComboBox.SelectedItem}' AND Product.ProductModelID IS NOT NULL";
                List<string> styles = new List<string>();
                styles = connection.Query<string>(styleSql).ToList();
                styleComboBox.Items.Clear();
                foreach (string style in styles)
                {
                    if (style == null)
                    {
                        styleComboBox.Enabled = false;
                    }
                    else
                    {
                        styleComboBox.Items.Add(style);
                    }
                }
            }
        }
        public void AddStyleListView()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
            {
                productModels = new List<ProductModel>();
                string addStSQL = $"SELECT DISTINCT Production.ProductModel.Name, Production.ProductDescription.Description FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID INNER JOIN Production.ProductDescription ON Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID WHERE Production.ProductModelProductDescriptionCulture.CultureID = 'en' AND Production.ProductSubcategory.Name = '{subCategoryComboBox.SelectedItem}' AND Production.Product.Style = '{styleComboBox.SelectedItem}' AND Product.ProductModelID IS NOT NULL";
                productModels = connection.Query<ProductModel>(addStSQL).ToList();
                resultListView.Items.Clear();
                foreach (ProductModel productModel in productModels)
                {
                    resultListView.Items.Add(productModel.ToString());
                }
            }
        }
        public void SelecSize()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
            {
                string sizeSQL = $"SELECT DISTINCT Production.Product.Size FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID  INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID WHERE ProductModelProductDescriptionCulture.CultureID = 'en'AND Production.ProductSubcategory.Name = '{subCategoryComboBox.SelectedItem}' AND Product.ProductModelID IS NOT NULL";
                List<string> sizes = new List<string>();
                sizes = connection.Query<string>(sizeSQL).ToList();
                sizeComboBox.Items.Clear();
                foreach (string size in sizes)
                { 
                    if (size == null)
                    {
                        sizeComboBox.Enabled = false;
                    }
                    else
                    {
                        sizeComboBox.Items.Add(size);
                    }
                }
            }
        }
        public void AddSizeListView()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
            {
                string addSizeSQL = $"SELECT DISTINCT Production.ProductModel.Name, Production.ProductDescription.Description FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID INNER JOIN Production.ProductDescription ON Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID WHERE Production.ProductModelProductDescriptionCulture.CultureID = 'en' AND Production.ProductSubcategory.Name = '{subCategoryComboBox.SelectedItem}' AND Production.Product.Size = '{sizeComboBox.SelectedItem}' AND Product.ProductModelID IS NOT NULL";
                productModels = new List<ProductModel>();
                productModels = connection.Query<ProductModel>(addSizeSQL).ToList();
                resultListView.Items.Clear();
                foreach (ProductModel productModel in productModels)
                {
                    resultListView.Items.Add(productModel.ToString());
                }
            }
        }
=======
>>>>>>> faa1180141c4e4c54ee49aadd8a4fa6db1bbef73
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
<<<<<<< HEAD
            AddCatListView();
=======
            addCatListView();
>>>>>>> faa1180141c4e4c54ee49aadd8a4fa6db1bbef73
        }

        private void subCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            AddSubListView();
            SelectStyle();
            SelecSize();
        }

        private void styleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddStyleListView();
        }

        private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddSizeListView();
=======
            addSubListView();
>>>>>>> faa1180141c4e4c54ee49aadd8a4fa6db1bbef73
        }
    }
}

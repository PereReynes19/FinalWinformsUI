using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.ComponentModel;
using System.Configuration;
using System.Data;

namespace WinformsUI_Project1
{
    public class ConsultsSQL
    {
       /* public List<ProductModel> productModels;
        MainForm mf = new MainForm();
        public new void SelectCategory()
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
                subCategoryComboBox.Items.Clear();
                foreach (string subcategory in subcategories)
                {
                    subCategoryComboBox.Items.Add(subcategory);
                }
            }
        }
        public void AddCatListView()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
            {
                productModels = new List<ProductModel>();
                string addCatSQL = $"SELECT DISTINCT Production.ProductModel.Name, Production.ProductDescription.Description FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID INNER JOIN Production.ProductDescription ON Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID WHERE Production.ProductModelProductDescriptionCulture.CultureID = 'en' AND Production.ProductCategory.Name = '{categoryComboBox.SelectedItem}' AND Product.ProductModelID IS NOT NULL";
                productModels = connection.Query<ProductModel>(addCatSQL).ToList();
                resultListView.Items.Clear();
                foreach (ProductModel productModel in productModels)
                {
                    resultListView.Items.Add(productModel.ToString());
                }
            }
        }
        public void AddSubListView()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
            {
                productModels = new List<ProductModel>();
                string addSubSQL = $"SELECT DISTINCT Production.ProductModel.Name, Production.ProductDescription.Description FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID INNER JOIN Production.ProductDescription ON Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID WHERE Production.ProductModelProductDescriptionCulture.CultureID = 'en' AND Production.ProductSubcategory.Name = '{subCategoryComboBox.SelectedItem}' AND Product.ProductModelID IS NOT NULL";
                productModels = connection.Query<ProductModel>(addSubSQL).ToList();
                resultListView.Items.Clear();
                foreach (ProductModel productModel in productModels)
                {
                    resultListView.Items.Add(productModel.ToString());
                }
            }
        }

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
        }*/
    }
}

using System;
using Dapper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsUI_Project1
{
    public partial class ProductForm : Form
    {
        int _productId;
        public ProductForm(int productId)
        {
            InitializeComponent();
            _productId = productId;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
            {
                string productsSQL = $"SELECT Production.ProductCategory.Name AS Category, Production.ProductSubcategory.Name AS Subcategory, Production.ProductModel.Name, Production.ProductDescription.Description, Production.Product.Name, Production.Product.ProductNumber, Production.Product.Color, Production.Product.ListPrice, Production.Product.Size,  Production.Product.ProductLine, Production.Product.Class, Production.Product.Style  FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID  INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID WHERE ProductModelProductDescriptionCulture.CultureID = 'en' AND Production.Product.ProductID = {_productId} AND Product.ProductModelID IS NOT NULL";
                Products productos = connection.Query<Products>(productsSQL).FirstOrDefault();
            }
        }
    }
}

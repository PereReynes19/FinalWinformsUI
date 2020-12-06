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
        Products productos;
        string _productModel;

        public ProductForm(string productModel)
        {
            InitializeComponent();
            _productModel = productModel;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
            {
                string productsSQL = $"SELECT Production.ProductCategory.Name AS Category, Production.ProductSubcategory.Name AS Subcategory, Production.ProductModel.Name, Production.ProductDescription.Description, Production.Product.Name, Production.Product.ProductNumber, Production.Product.Color, Production.Product.ListPrice, Production.Product.Size,  Production.Product.ProductLine, Production.Product.Class, Production.Product.Style  FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID  INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID WHERE ProductModelProductDescriptionCulture.CultureID = 'en' AND Production.ProductModel.Name = '{_productModel}' AND Product.ProductModelID IS NOT NULL";
                productos = connection.Query<Products>(productsSQL).FirstOrDefault();
                TextBoxesDisabled();

                categoryTextBox.Text = productos.Category.ToString();
                subCategoryTextBox.Text = productos.Subcategory.ToString();
                listPriceTextBox.Text = productos.ListPrice.ToString();
                productNumberTextBox.Text = productos.ProductNumber.ToString();
                descriptionTextBox.Text = productos.Description.ToString();
                productModelTextBox.Text = _productModel;

                AddList();
            }
        }

        private void TextBoxesDisabled()
        {
            categoryTextBox.Enabled = false;
            subCategoryTextBox.Enabled = false;
            productNumberTextBox.Enabled = false;
            productModelTextBox.Enabled = false;
        }

        private void AddList()
        {
            if (productos.Size != null)
            {
                sizeComboBox.Items.Add(productos.Size);
            }
            if (productos.Style != null)
            {
                styleComboBox.Items.Add(productos.Style);
            }
            if (productos.ProducLine != null)
            {
                productLineComboBox.Items.Add(productos.ProducLine);
            }
            if (productos.Color != null)
            {
                colorComboBox.Items.Add(productos.Color);
            }
            if (productos.Class != null)
            {
                classComboBox.Items.Add(productos.Class);
            }  
        }
        private void UpdateProduct()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
            {
                string mainQuery = $"SELECT Production.ProductDescription.ProductDescriptionID FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID  INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID WHERE Production.ProductModel.ProductModelID = {productos.ProductModelID} AND Production.ProductModelProductDescriptionCulture.CultureID = 'en'";
                int descriptionID = connection.ExecuteScalar<int>(mainQuery);
                string updateDescription = $"UPDATE Production.ProductDescription SET Description = '{descriptionTextBox.Text}' WHERE Production.ProductDescription.ProductDescriptionID = {descriptionID}";
                connection.Execute(updateDescription);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }
    }
}

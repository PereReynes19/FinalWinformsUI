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
using Syncfusion.Windows.Forms.Tools;

namespace WinformsUI_Project1
{
	public partial class MainForm : Form
	{
		private List<ProductModel> productModels;
		private List<Product> products;
		private string lenguatge = "en";
		private string avaliable = "";
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
				string addCatSQL = $"SELECT DISTINCT Production.ProductModel.Name, Production.ProductDescription.Description FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID INNER JOIN Production.ProductDescription ON Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID WHERE Production.ProductModelProductDescriptionCulture.CultureID = '{lenguatge}' AND Production.ProductCategory.Name = '{categoryComboBox.SelectedItem}' {avaliable} AND Product.ProductModelID IS NOT NULL";
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
				string addSubSQL = $"SELECT DISTINCT Production.ProductModel.Name, Production.ProductDescription.Description FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID INNER JOIN Production.ProductDescription ON Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID WHERE Production.ProductModelProductDescriptionCulture.CultureID = '{lenguatge}' AND Production.ProductSubcategory.Name = '{subCategoryComboBox.SelectedItem}' {avaliable} AND Product.ProductModelID IS NOT NULL";
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
						styleComboBox.Enabled = true;
					}
				}
			}
		}
		public void AddStyleListView()
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
			{
				productModels = new List<ProductModel>();
				string addStSQL = $"SELECT DISTINCT Production.ProductModel.Name, Production.ProductDescription.Description FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID INNER JOIN Production.ProductDescription ON Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID WHERE Production.ProductModelProductDescriptionCulture.CultureID = '{lenguatge}' AND Production.ProductSubcategory.Name = '{subCategoryComboBox.SelectedItem}' {avaliable} AND Production.Product.Style = '{styleComboBox.SelectedItem}' AND Product.ProductModelID IS NOT NULL";
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
						sizeComboBox.Enabled = true;
					}
				}
			}
		}
		public void AddSizeListView()
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
			{
				string addSizeSQL = $"SELECT DISTINCT Production.ProductModel.Name, Production.ProductDescription.Description FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID INNER JOIN Production.ProductDescription ON Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID WHERE Production.ProductModelProductDescriptionCulture.CultureID = '{lenguatge}' AND Production.ProductSubcategory.Name = '{subCategoryComboBox.SelectedItem}' {avaliable} AND Production.Product.Size = '{sizeComboBox.SelectedItem}' AND Product.ProductModelID IS NOT NULL";
				productModels = new List<ProductModel>();
				productModels = connection.Query<ProductModel>(addSizeSQL).ToList();
				resultListView.Items.Clear();
				foreach (ProductModel productModel in productModels)
				{
					resultListView.Items.Add(productModel.ToString());
				}
			}
		}

		public void SelectClass()
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
			{
				string classSQL = $"SELECT DISTINCT Production.Product.Class FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID  INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID WHERE ProductModelProductDescriptionCulture.CultureID = 'en'AND Production.ProductSubcategory.Name = '{subCategoryComboBox.SelectedItem}' AND Product.ProductModelID IS NOT NULL";
				List<string> classes = new List<string>();
				classes = connection.Query<string>(classSQL).ToList();
				classComboBox.Items.Clear();
				foreach (string class1 in classes)
				{
					if (class1 == null)
					{
						classComboBox.Enabled = false;
					}
					else
					{
						classComboBox.Items.Add(class1);
						classComboBox.Enabled = true;
					}
				}
			}
		}
		public void AddClassListView()
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
			{
				string addClassSQL = $"SELECT DISTINCT Production.ProductModel.Name, Production.ProductDescription.Description FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID INNER JOIN Production.ProductDescription ON Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID WHERE Production.ProductModelProductDescriptionCulture.CultureID = '{lenguatge}' AND Production.ProductSubcategory.Name = '{subCategoryComboBox.SelectedItem}' {avaliable} AND Production.Product.Class = '{classComboBox.SelectedItem}' AND Product.ProductModelID IS NOT NULL";
				productModels = new List<ProductModel>();
				productModels = connection.Query<ProductModel>(addClassSQL).ToList();
				resultListView.Items.Clear();
				foreach (ProductModel productModel in productModels)
				{
					resultListView.Items.Add(productModel.ToString());
				}
			}
		}
		public void SelectColor()
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
			{
				string colorSQL = $"SELECT DISTINCT Production.Product.Color FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID  INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID WHERE ProductModelProductDescriptionCulture.CultureID = 'en'AND Production.ProductSubcategory.Name = '{subCategoryComboBox.SelectedItem}' AND Product.ProductModelID IS NOT NULL";
				List<string> colors = new List<string>();
				colors = connection.Query<string>(colorSQL).ToList();
				colourComboBox.Items.Clear();
				foreach (string colour in colors)
				{
					if (colour == null)
					{
						colourComboBox.Enabled = false;
					}
					else
					{
						colourComboBox.Items.Add(colour);
						colourComboBox.Enabled = true;
					}
				}
			}
		}
		public void AddColorListView()
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
			{
				string addColorSQL = $"SELECT DISTINCT Production.ProductModel.Name, Production.ProductDescription.Description FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID INNER JOIN Production.ProductDescription ON Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID WHERE Production.ProductModelProductDescriptionCulture.CultureID = '{lenguatge}' AND Production.ProductSubcategory.Name = '{subCategoryComboBox.SelectedItem}' AND Production.Product.Color = '{colourComboBox.SelectedItem}' {avaliable} AND Product.ProductModelID IS NOT NULL";
				productModels = new List<ProductModel>();
				productModels = connection.Query<ProductModel>(addColorSQL).ToList();
				resultListView.Items.Clear();
				foreach (ProductModel productModel in productModels)
				{
					resultListView.Items.Add(productModel.ToString());
				}
			}
		}

		public void SelectProductLine()
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
			{
				string productSQL = $"SELECT DISTINCT Production.Product.ProductLine FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID  INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID WHERE ProductModelProductDescriptionCulture.CultureID = 'en' AND Production.ProductSubcategory.Name = '{subCategoryComboBox.SelectedItem}' AND Product.ProductModelID IS NOT NULL";
				List<string> products = new List<string>();
				products = connection.Query<string>(productSQL).ToList();
				productLineComboBox.Items.Clear();
				foreach (string product in products)
				{
					if (product == null)
					{
						productLineComboBox.Enabled = false;
					}
					else
					{
						productLineComboBox.Items.Add(product);
						productLineComboBox.Enabled = true;
					}
				}
			}
		}

		public void AddProLineListView()
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
			{
				string addProLineSQL = $"SELECT DISTINCT Production.ProductModel.Name, Production.ProductDescription.Description FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID INNER JOIN Production.ProductDescription ON Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID WHERE Production.ProductModelProductDescriptionCulture.CultureID = '{lenguatge}' AND Production.ProductSubcategory.Name = '{subCategoryComboBox.SelectedItem}' AND Production.Product.ProductLine = '{productLineComboBox.SelectedItem}' {avaliable} AND Product.ProductModelID IS NOT NULL";
				productModels = new List<ProductModel>();
				productModels = connection.Query<ProductModel>(addProLineSQL).ToList();
				resultListView.Items.Clear();
				foreach (ProductModel productModel in productModels)
				{
					resultListView.Items.Add(productModel.ToString());
				}
			}
		}

		public void selectText()
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
			{
				string textSQL = $"SELECT DISTINCT Production.ProductModel.Name, Production.ProductDescription.Description FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID INNER JOIN Production.ProductDescription ON Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID WHERE Production.ProductModelProductDescriptionCulture.CultureID = '{lenguatge}' AND Production.ProductSubcategory.Name = '{subCategoryComboBox.SelectedItem}' AND Production.ProductModel.Name LIKE '%{queryTextBox.Text}%' {avaliable} AND Product.ProductModelID IS NOT NULL";
				productModels = new List<ProductModel>();
				productModels = connection.Query<ProductModel>(textSQL).ToList();
				resultListView.Items.Clear();
				foreach (ProductModel productModel in productModels)
				{
					resultListView.Items.Add(productModel.ToString());
				}
			}
		}
		public void productText()
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
			{
				string productSQL = $"SELECT DISTINCT Production.Product.Name, Production.ProductDescription.Description FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID INNER JOIN Production.ProductDescription ON Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID WHERE Production.ProductModelProductDescriptionCulture.CultureID = '{lenguatge}' AND Production.ProductSubcategory.Name = '{subCategoryComboBox.SelectedItem}' AND Production.ProductModel.Name LIKE '%{productTextBox.Text}%' {avaliable} AND Product.ProductModelID IS NOT NULL";
				products = new List<Product>();
				products = connection.Query<Product>(productSQL).ToList();
				resultListView.Items.Clear();
				foreach (Product product in products)
				{
					resultListView.Items.Add(product.ToString());
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
			minLPTextBox.Text = "0";
		}

		private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			SelectSubCategory();
			AddCatListView();
		}

		private void subCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			AddSubListView();
			SelectStyle();
			SelecSize();
			SelectClass();
			SelectColor();
			SelectProductLine();
		}

		private void styleComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			AddStyleListView();
			classComboBox.Text = "";
			sizeComboBox.Text = "";
			colourComboBox.Text = "";
			productLineComboBox.Text = "";
		}

		private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			AddSizeListView();
			classComboBox.Text = "";
			styleComboBox.Text = "";
			colourComboBox.Text = "";
			productLineComboBox.Text = "";
		}

		private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			AddClassListView();
			sizeComboBox.Text = "";
			styleComboBox.Text = "";
			colourComboBox.Text = "";
			productLineComboBox.Text = "";
		}

		private void colourComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			AddColorListView();
			sizeComboBox.Text = "";
			styleComboBox.Text = "";
			classComboBox.Text = "";
			productLineComboBox.Text = "";
		}

		private void productLineComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			AddProLineListView();
			sizeComboBox.Text = "";
			styleComboBox.Text = "";
			classComboBox.Text = "";
			colourComboBox.Text = "";
		}

		private void queryTextBox_TextChanged(object sender, EventArgs e)
		{
			selectText();
			sizeComboBox.Text = "";
			styleComboBox.Text = "";
			classComboBox.Text = "";
			colourComboBox.Text = "";
			productLineComboBox.Text = "";
		}

		private void lenguageToggleButton_Click(object sender, EventArgs e)
		{
			if (lenguageToggleButton.ToggleState == ToggleButtonState.Active)
			{
				lenguatge = "en";
			}
			if (lenguageToggleButton.ToggleState == ToggleButtonState.Inactive)
			{
				lenguatge = "fr";
			}

		}
		private void resultListView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
			{
				string productSelectet = resultListView.SelectedItems[0].Text;
				productSelectet = productSelectet.Split(',')[0];

				ProductForm pf = new ProductForm(productSelectet);
				pf.ShowDialog();
			}
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			categoryComboBox.Text = "";
			subCategoryComboBox.Text = "";
			resultListView.Items.Clear();
			styleComboBox.Text = "";
			classComboBox.Text = "";
			sizeComboBox.Text = "";
			colourComboBox.Text = "";
			productLineComboBox.Text = "";
		}

		private void avaliableButton_Click(object sender, EventArgs e)
		{
			avaliable = "AND Production.Product.SellEndDate IS NOT NULL";
		}

		private void nonAvaliableButton_Click(object sender, EventArgs e)
		{
			avaliable = "";
		}

		private void productTextBox_TextChanged(object sender, EventArgs e)
		{
			productText();
		}
        private void maxLPTextBox_TextChanged(object sender, EventArgs e)
        {
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorksDB")))
			{
				string maxPrice = $"SELECT DISTINCT Production.ProductModel.Name, Production.ProductDescription.Description FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID INNER JOIN Production.ProductDescription ON Production.ProductDescription.ProductDescriptionID = Production.ProductModelProductDescriptionCulture.ProductDescriptionID WHERE Production.ProductModelProductDescriptionCulture.CultureID = '{lenguatge}' AND Production.ProductSubcategory.Name = '{subCategoryComboBox.SelectedItem}' AND Production.Product.ListPrice BETWEEN {minLPTextBox.Text} AND {maxLPTextBox.Text} {avaliable} AND Product.ProductModelID IS NOT NULL";
				products = new List<Product>();
				products = connection.Query<Product>(maxPrice).ToList();
				resultListView.Items.Clear();
				foreach (Product product in products)
				{
					resultListView.Items.Add(product.ToString());
				}
			}
		}
	}
}

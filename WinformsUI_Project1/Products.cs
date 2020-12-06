using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsUI_Project1
{
    public class Products
    {
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public string ProducModel { get; set; }
        public string Description { get; set; }
        public string ProductNumber { get; set; }
        public string Color { get; set; }
        public int ListPrice { get; set; }
        public string Size { get; set; }
        public string ProducLine { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public int ProductModelID { get; set; }

        public override string ToString()
        {
            return $"{Category}, {Subcategory}, {ProducModel}, {Description}, {ProductNumber}, {Color}, {ListPrice}, {Size}, {ProducLine}, {Class}, {Style}, {ProductModelID}";
        }
    }
}

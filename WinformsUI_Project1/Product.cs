﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsUI_Project1
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Description}";
        }
    }
}
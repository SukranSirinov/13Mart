﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class Product
    {
        public Product(int no, string name, double price)
        {
            this.No = no;
            this.Name = name;
            this.Price = price;

        }
        public int No;
        public string Name;
        public double Price;
        public int Count;
    }
}

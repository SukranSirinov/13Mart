using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class Book:Product
    {
        public Book(int no, string name, double price, string genre) : base(no, name, price)
        {
            this.Genre = genre;
        }
        public string Genre;
        public string Getinfo()
        {
            return $"No:{this.No} - Name: {this.Name} - Price:{this.Price} - Genre: {this.Genre} - ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace task8
{
    internal class Product : IComparable<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    
        public int CompareTo(Product other)
        {
            return Price.CompareTo(other.Price);
        }
    
        public override string ToString()
        {
            return $"{Id} - {Name} - {Price}";
        }
    }
}

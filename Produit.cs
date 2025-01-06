using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceProjet
{
    public class Produit
    {
        private decimal _price;
        private string _name;
        private string _description;
        private string _category;
        private Size _size;

        public Produit(string name, decimal price, string description, string category, Size size)
        {
            _name = name;
            _price = price;
            _description = description;
            _category = category;
            _size = size;
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public Size Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public override string ToString()
        {
            return $"Name: {_name}, Price: {_price}, Description: {_description}, Category: {_category}, Size: {_size}";
        }

        // Virtual method 
        public virtual void DisplayProductDetails()
        {
            Console.WriteLine($"Name: {_name}, Price: {_price}, Description: {_description}, Category: {_category}, Size: {_size}");
        }

        public static decimal CalculateDiscount(decimal price, decimal discountPercentage)
        {
            return  price - (price * discountPercentage / 100);
        }
        

        
    }



}
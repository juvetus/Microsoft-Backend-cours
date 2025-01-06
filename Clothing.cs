using System;
using System.Collections.Generic;
using System.Drawing;


using System.Linq;
using System.Threading.Tasks;

namespace EcommerceProjet
{
    public enum Size
    {
       XS,
       S,
       M,
       L,
       XL
}
    public class Clothing : Produit, IDiscountable
    {
        private decimal _price;
        private string _name;
        private string _description;
        private string _category;
        private Size _size;

        public Clothing(string name, decimal price, string description, string category, Size size) : base(name, price, description, category, size)
        {
            _name = name;
            _price = price;
            _description = description;
            _category = category;
            _size = size;
        }



        public new decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public new string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public new string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        
        public new string Category
        {
            get { return _category; }
            set { _category = value; }
        }

          public new Size Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public string DisplaySizeName()
        {
            return Size switch 
            {
                Size.XS => "Extra Small",
                Size.S => "Small",
                Size.M => "Medium",
                Size.L => "Large",
                Size.XL => "Extra Large",
                _ => "Unknown"
            };
        }
        
       
        public decimal ApplyDiscount(decimal pourcentage)
        {
            return Price - (Price * pourcentage / 100);
        }


        public override void DisplayProductDetails()
        {
            base.DisplayProductDetails();
            Console.WriteLine($"Size: {DisplaySizeName()}");
        }



    }

    
       
    
}
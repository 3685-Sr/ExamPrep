using System;
using System.Collections.Generic;
using System.Text;

namespace UASD_Retake
{
    public class Cocktail
    {
        private string name;
        private double price;

        public Cocktail(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public override string ToString()
        {
            return $"Cocktail {this.name} costs {this.price:F2} lv.";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UASD_Retake
{
    public class Bar
    {
        private string name;
        private List<Cocktail> cocktails;

        public Bar(string name)
        {
            Name = name;
            this.cocktails = new List<Cocktail>();
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

        public List<Cocktail> Cocktails
        {
            get
            {
                return this.cocktails;
            }
            set
            {
                this.cocktails = value;
            }
        }

        public void AddCocktail(string name, double price)
        {
            Cocktail cocktail = new Cocktail(name, price);
            cocktails.Add(cocktail);
        }

        public double AveragePriceInRange(double start, double end)
        {
            return cocktails.Where(x => x.Price >= start && x.Price <= end).Average(x => x.Price);
        }

        public List<string> FilterCocktailsByPrice(double price)
        {
            return cocktails.Where(x => x.Price < price).Select(x => x.Name).ToList();
        }

        public List<Cocktail> SortAscendingByName()
        {
            return cocktails.OrderBy(x => x.Name).ToList();
        }

        public List<Cocktail> SortDescendingByPrice()
        {
            return cocktails.OrderByDescending(x => x.Price).ToList();
        }

        public bool CheckCocktailIsInBar(string name)
        {
            return cocktails.Any(x => x.Name == name);
        }

        public string[] ProvideInformationAboutAllCocktails()
        {
            return cocktails.Select(x => x.ToString()).ToArray();
        }
    }
}

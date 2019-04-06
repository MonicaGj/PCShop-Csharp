using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Configuration
    {
        public Colors Colors { get; set; }
        public string Name { get; set; }
        public Colors BoxColor { get; set; }
        public List<Module> Modules { get; set; } = new List<Module>();
        public List<Part> PartsToProduct { get; set; } = new List<Part>();
        public double ConfigDiscount { get; set; }


        public Configuration(Colors colors)
        {
            this.Colors = colors;
        }

        public void AddModuleToProduct(Module m, int q)
        {
            for (int i = 0; i < q; i++)
            {
                Modules.Add(m);
            }
        }

        public void AddPartToProduct(Part p, int q)
        {
            for (int i = 0; i < q; i++)
            {
                PartsToProduct.Add(p);
            }
        }

        public double GetPrice()
        {
            double TotalPrice = 0;
            foreach (var part in PartsToProduct)
            {
                TotalPrice += part.Price;
            }

            foreach (var module in Modules)
            {
                TotalPrice += module.GetPrice();
            }
            return TotalPrice;
        }

        public double SetDiscount(double discount)
        {

            ConfigDiscount = (discount / 100);
            return ConfigDiscount;
        }

        public double GetPriceWithDiscount()
        {

            double discount = (GetPrice() * ConfigDiscount);
            return GetPrice() - discount;
        }




    

    }
}

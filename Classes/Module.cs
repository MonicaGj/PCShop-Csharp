using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Module 
    {
        public string Name { get; set; }
        public List<Part> Parts { get; set; } = new List<Part>();
        public double Discount { get; set; } 

        public Module(string name)
        {
            this.Name = name;
        }

        public void AddPartToModule(Part p, int q)
        {
            for (int i = 0; i < q; i++)
            {
                Parts.Add(p);
            }
          
        }

        public double SetDiscount(double discount)
        {
             
            Discount = (discount / 100);
            return Discount;
        }


        public double GetPrice()
        {
            double TotalPrice = 0;
            foreach (var part in Parts)
            {
                TotalPrice += part.Price;
            }
            return TotalPrice;
        }

        public double GetPriceWithDiscount()
        {
            double discount   = (GetPrice() * Discount);
            return GetPrice() - discount;
        }

    }
}

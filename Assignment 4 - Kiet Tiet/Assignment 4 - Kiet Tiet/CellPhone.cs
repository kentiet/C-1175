using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4___Kiet_Tiet
{
    class CellPhone
    {
        private string brand;   //Phone's brand
        private string model;   //Phone's model
        private decimal price;  //Phone's price

        public CellPhone()          // Contructor
        {
            brand = "";
            model = "";
            price = 0m;
        }

        public string GetBrand()
        {
            return brand;
        }

        public void SetBrand(string newBrand)
        {
            brand = newBrand;
        }

        public string GetModel()
        {
            return model;
        }

        public void SetModel(string newModel)
        {
            model = newModel;
        }

        public decimal GetPrice()
        {
            return price;
        }

        public void SetPrice(decimal newPrice)
        {
            price = newPrice;
        }
    }
}

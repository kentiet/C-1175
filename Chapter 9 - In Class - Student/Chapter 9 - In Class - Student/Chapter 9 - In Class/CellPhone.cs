using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9___In_Class
{
    class CellPhone
    {                                   // Fields       
        private string _brand;          // The phone's brand
        private string _model;          // The phone's model
        private decimal _price;         // Retail price
      
        public CellPhone()              // Constructor
        {
            _brand = "";                // Private Backing fields
            _model = "";
            _price = 0m;
        }
      
        public string Brand             // Brand property - Method 1 to declare
        {
            get { return _brand; }
            set { _brand = value; }
        }    
        public string Model             // Model property - Method 2 to declare
        {
            get; set;
        }    
        public decimal Price { get; set; } // Price property - Method 3 to declare

    }
}

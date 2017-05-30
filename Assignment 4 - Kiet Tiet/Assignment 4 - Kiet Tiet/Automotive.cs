using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4___Kiet_Tiet
{
    class Automotive
    {
        private string cusName;             // Customer's name
        private string cusAddress;          // Customer's address
        private string cusPhone;             // Customer's phone
        private string brand;                   // car's brand
        private string model;                   // car's model
        private int year;                          // car's year
        private decimal partCharge;         // part charge
        private decimal laborCharge;        // labor charge
        private decimal tax;                     // tax rate

        public Automotive()                 // contructor
        {
            cusName = "";
            cusAddress = "";
            cusPhone = "";
            brand = ""; 
            model = "";
            year = 0;
            partCharge = 0m;
            laborCharge = 0m;
            tax = 0m;
        }

        public string GetCustomerName
        {
            get { return cusName; }
            set { cusName = value;}
        }

        public string GetCustomerAddress
        {
            get { return cusAddress; }
            set { cusAddress = value; }
        }

        public string GetCustomerPhone
        {
            get { return cusPhone; }
            set { cusPhone = value; }
        }
        public string GetBrand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string GetModel
        {
            get { return model; }
            set { model = value; }
        }

        public int GetYear
        {
            get { return year; }
            set { year = value; }
        }

        public decimal GetPartCharge
        {
            get { return partCharge; }
            set { partCharge = value; }
        }

        public decimal GetLaborCharge
        {
            get { return laborCharge; }
            set { laborCharge = value; }
        }

        public decimal GetTaxRate
        {
            get { return tax; }
            set { tax = value; }
        }

        public decimal CalculateCharge(decimal partCharge, decimal laborCharge, decimal taxRate)  //Calculate the total charge method
        {
            decimal totalCharge;
            totalCharge = (partCharge + laborCharge) * (taxRate + 1);

            return totalCharge;
        }
    }
}

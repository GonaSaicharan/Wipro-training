using System;
using System.Collections.Generic;
using System.Text;

namespace Day3_Abstarct
{
    abstract class Product: IDiscountTable
    {
        public int ProductID {  get; set; }
        public string ProductName { get; set; }

        public double CalculateDiscount(double Price)
        {
            throw new NotImplementedException();
        }

        public abstract void DisplayProductDetails();

        void displayProductDetailsonly()
        {
            Console.WriteLine("Product Name" + ProductName);
        }
    }
}

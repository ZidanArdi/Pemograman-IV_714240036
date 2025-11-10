using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240036
{
    internal class ProductTest_714240036
    {
        static void Main(string[] args)
        {
            //Product_714240036 myProduct = new Product_714240036();

            //// Ganti 'myProduct.myType' menjadi 'myProduct.MyType'
            //myProduct.MyType = "DVD";

            //// Ganti 'myProduct.myType' menjadi 'myProduct.MyType'
            //Console.WriteLine(myProduct.MyType);

            Book_714240036 product1 = new Book_714240036("Book", "C# Programming", "350");
            DVD_714240036 product2 = new DVD_714240036("Ethernal Sunshine of The Spotless Mind", "148");

            product1 .DisplayInfo();
            product2.DisplayInfo();
        }
    }
}
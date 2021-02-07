using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "klavye";
            product1.CategoryId = 3;
            product1.UnitPrice = 300;
            product1.UnitInStock = 5;

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);


            

        }
    }
}

using System;
using System.Collections.Generic;


namespace Product.assignment
{ 
    public class Program
    {
       public static void Main()
        {
            var products = new List<Product>()
           {
               new Product { Name = "Milo", Quantity = 20},
               new Product { Name = "Golden Penny Semovita", Quantity = 10},
               new Product { Name = "Ayoola Poundo Yam Flour", Quantity = 6},
               new Product { Name = "Indomie Onion chicken", Quantity = 3 },
               new Product { Name = "Heinz: Tomato paste", Quantity = 7 },
               new Product { Name = "Golden Morn", Quantity = 25},
               new Product { Name = "Nescafe Clasic", Quantity = 9},
               new Product { Name = "5 Alive tropical juice", Quantity = 4},
               new Product { Name = "Eva Table water 750ml", Quantity = 2},
               new Product { Name = "Titus: Sardines", Quantity = 3}
           };
            Console.WriteLine("Before sorting");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine( );



            products.Sort(new Product());           
            products.Reverse();
            Console.WriteLine("After Sorting");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }

            Console.ReadLine();
        }

        public class Product : IComparer<Product>
        {
            public string Name { get; set; }
            public int Quantity { get; set; }

            public int Compare(Product x, Product y)
            {
                if (x.Quantity > y.Quantity)
                {
                    return 1;
                }
                else if (x.Quantity < y.Quantity)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            public override string ToString()
            {
                return $"Name: {Name}, Quantity: {Quantity} ";
            }
        }

       
    }
}

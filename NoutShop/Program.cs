using NoutShop.Services; 
using System;
using Npgsql;
using NoutShop.Services.Interfaces;
using NoutShop.Models;

class Program
{
    static void Main()
    {
        //while (true)
        //{
        IProductService productService = new ProductService();

        Products products = new Products();

            Console.WriteLine("\t\t\t\t\t\t ____________________________________ ");
            Console.WriteLine("\t\t\t\t\t\t|                                    |");
            Console.WriteLine("\t\t\t\t\t\t|           NOUTBOOK SHOP            |");
            Console.WriteLine("\t\t\t\t\t\t|____________________________________|\n\n");

            Console.WriteLine(" ____________________________________   \t\t\t\t\t\t   ____________________________________");
            Console.WriteLine("|                                    |  \t\t\t\t\t\t  |                                    |");
            Console.WriteLine("|             1.  PRODUCTS           |  \t\t\t\t\t\t  |              2. ORDERS             |");
            Console.WriteLine("|____________________________________|  \t\t\t\t\t\t  |____________________________________|\n\n\n\n\n");

        Console.Write("Qaysi amalni bajarasiz? (1/2) >> ");
        int num =int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1:
                Console.WriteLine(" ________________________         _________________________       _______________________         ________________________");
                Console.WriteLine("|                        |       |                         |      |                      |       |                        |");
                Console.WriteLine("| 1. PRODUCT QO'SHISH    |       | 2. PRODUCTNI YANGILASH  |      | 3. PRODUCT RO'YXATI  |       | 4. PRODUCTNI O'CHIRISH |");
                Console.WriteLine("|________________________|       |_________________________|      |______________________|       |________________________|\n\n\n");

                 

                Console.Write("Qanday amal bajarasiz? (1/2/3/4) >> ");
                int num1 = int.Parse(Console.ReadLine());
                switch (num1)
                {

                    case 1:                                      // product qoshish


                        Console.Write("Nechta mahsulot qoshmoqchisiz ? ");
                        int count = int.Parse(Console.ReadLine());

                        for (int i = 0; i < count; i++)
                        {

                            Console.Write("Product name: ");
                            string name = Console.ReadLine();

                            Console.Write("Product price: ");
                            double price = int.Parse(Console.ReadLine());

                            Console.Write("Product category: ");
                            string category = Console.ReadLine();

                            {

                                // products.Id = id;
                                products.Name = name;
                                products.Price = price;
                                products.Category = category;

                            };
                            Console.WriteLine();
                            var result = productService.Create(products);
                            Console.WriteLine(result);


                        }

                        break;
                    case 2:                       //productni yangilash


                        break;

                }


                break;


            case 2:
                Console.WriteLine(" ________________________         _________________________       _______________________         ________________________");
                Console.WriteLine("|                        |       |                         |      |                      |       |                        |");
                Console.WriteLine("| 1. BUYURTMA BERISH     |       | 2.BUYURTMANI YANGILASH  |      | 3.BUYURTMA RO'YXATI  |       | 4.BUYURTMANI O'CHIRISH |");
                Console.WriteLine("|________________________|       |_________________________|      |______________________|       |________________________|\n\n\n");


                break;
        }



    }
}


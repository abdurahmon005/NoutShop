using NoutShop.Models;
using NoutShop.Services;
using NoutShop.Services.Interfaces;

namespace NoutShop
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

            Console.WriteLine("\t\t\t\t\t\t ____________________________________ ");
            Console.WriteLine("\t\t\t\t\t\t|                                    |");
            Console.WriteLine("\t\t\t\t\t\t|           NOUTBOOK SHOP            |");
            Console.WriteLine("\t\t\t\t\t\t|____________________________________|\n\n");

            Console.WriteLine(" ____________________________________   \t\t\t\t\t\t   ____________________________________");
            Console.WriteLine("|                                    |  \t\t\t\t\t\t  |                                    |");
            Console.WriteLine("|             1.  PRODUCTS           |  \t\t\t\t\t\t  |              2. ORDERS             |");
            Console.WriteLine("|____________________________________|  \t\t\t\t\t\t  |____________________________________|\n\n\n\n\n");

           

                IProductService service = new ProductService();

                Console.Write("(1 and 2) >>> ");
                int num = int.Parse(Console.ReadLine());
            
                switch (num)
                {
                    case 1:
                        Console.WriteLine(" ____________________________________         ____________________________________      ____________________________________");
                        Console.WriteLine("|                                    |       |                                    |    |                                    |");
                        Console.WriteLine("|         1. PRODUCT QO'SHISH        |       |       2. PRODUCTNI YANGILASH       |    |        3. PRODUCTNI O'CHIRISH      |");
                        Console.WriteLine("|____________________________________|       |____________________________________|    |____________________________________|\n\n\n");

                        Console.WriteLine(" ____________________________________         ____________________________________      ____________________________________");
                        Console.WriteLine("|                                    |       |                                    |    |                                    |");
                        Console.WriteLine("|        4. PRODUCT RO'YXATI         |       |        5. NARXNI OZGARTIRISH       |    |           6. GET BY ID             |");
                        Console.WriteLine("|____________________________________|       |____________________________________|    |____________________________________|\n\n\n\n");

                        Console.Write("1 to 6 >>> ");
                        int num1 = int.Parse(Console.ReadLine());
                        switch (num1)
                        {

                            case 1:
                                Products products = new Products();

                                Console.Write("Nechta mahsulot qoshmoqchisiz ? ");
                                int count = int.Parse(Console.ReadLine());

                                for (int i = 0; i < count; i++)
                                {
                                    Console.Write("Product Id: ");
                                    int id = int.Parse(Console.ReadLine());

                                    Console.Write("Product name: ");
                                    string name = Console.ReadLine();

                                    Console.Write("Product price: ");
                                    double price = int.Parse(Console.ReadLine());

                                    Console.Write("Product category: ");
                                    string category = Console.ReadLine();

                                    {

                                        products.Id = id;
                                        products.Name = name;
                                        products.Price = price;
                                        products.Category = category;

                                    };
                                    Console.WriteLine();
                                    var result = service.Create(products);
                                    Console.WriteLine(result);

                                }

                                break;
                        }


                        break;


                    case 2:
                        Console.WriteLine(" ____________________________________         ____________________________________      ____________________________________");
                        Console.WriteLine("|                                    |       |                                    |    |                                    |");
                        Console.WriteLine("|        1. BUYURTMA BERISH          |       |       2. BUYURTMANI YANGILASH      |    |       3.BUYURTMANI O'CHIRISH       |");
                        Console.WriteLine("|____________________________________|       |____________________________________|    |____________________________________|\n\n\n");

                        Console.WriteLine(" ____________________________________         ____________________________________      ____________________________________");
                        Console.WriteLine("|                                    |       |                                    |    |                                    |");
                        Console.WriteLine("|        4. BUYURTMA RO'YXATI        |       |           5.                       |    |       6.                           |");
                        Console.WriteLine("|____________________________________|       |____________________________________|    |____________________________________|\n\n\n\n");
                        break;
                }

                var product = service.GetAll();
                foreach (var item in product)
                {
                    Console.WriteLine($" ID: {item.Id} \n Name: {item.Name} \n Price: {item.Price}$ \n Category: {item.Category} \n Created data: {item.CreatedTime}");
                }

                Console.WriteLine("\nDavom etish uchun istalgan tugmani bosing...");


                Console.ReadKey();

                Console.Clear();

            }

        }

    }
}
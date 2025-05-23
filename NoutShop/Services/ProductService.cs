using NoutShop.Models;
using NoutShop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace NoutShop.Services
{
    class ProductService : IProductService
    {
         string connStr = "Host=localhost;Port=5432;Username=postgres;Password=abdurahmon7985;Database=noutshop";

        public string Create(Products products)
        {

            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string InsertQuery = @"INSERT INTO product 
                 (product_name, product_category, product_price, product_create_time)
                 VALUES (@name, @category, @price, @createdTime)";

                using (var cmd = new NpgsqlCommand(InsertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@name", products.Name);
                    cmd.Parameters.AddWithValue("@price", products.Price);
                    cmd.Parameters.AddWithValue("@category", products.Category);
                    cmd.Parameters.AddWithValue("@createdTime", products.CreatedTime);

                    cmd.ExecuteNonQuery();

                }
            }

            return "Mahsulot bazaga qo‘shildi";
        }

        public void Delete(int productId)
        {
           

            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                string query = "DELETE FROM product WHERE product_id = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", productId);
                    cmd.ExecuteNonQuery();

                     
                        Console.WriteLine("Mahsulot muvaffaqiyatli o'chirildi.");
                   
                }
            }
        }

        public IEnumerable<Products> GetAll()
        {
            throw new NotImplementedException();
        }



        public Products Update(Products products)
        {
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string UpdateQuery = @"UPDATE product SET product_price = @price WHERE product_id = @id;";

                using (var cmd = new NpgsqlCommand(UpdateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("price", products.Price);
                    cmd.Parameters.AddWithValue("id", products.Id);

                    cmd.ExecuteNonQuery();
                    Console.WriteLine("✅ Ma'lumot muvaffaqiyatli yangilandi.");
                }
            }

            return products;
        }
        public Products GetByID(int idproduct)
        {
            throw new NotImplementedException();
        }

        public List<Products> Read()
        {
            var products = new List<Products>();


            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT product_id, product_name, product_category, product_price, product_create_time FROM product";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new Products
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Category = reader.GetString(2),
                            Price = reader.GetDouble(3),
                            CreatedTime = reader.GetDateTime(4)
                        };

                        products.Add(product);
                    }
                }
            }

            return products;
        }


    }
}

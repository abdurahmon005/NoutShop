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
       
        public string Create(Products products)
        {
            string connStr = "Host=localhost;Port=5432;Username=postgres;Password=abdurahmon7985;Database=noutshop";
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string insertQuery = @"INSERT INTO product 
                (product_name, product_category, product_price, product_create_time)
                VALUES (@name, @category, @price, @createdTime)";

                using (var cmd = new NpgsqlCommand(insertQuery, conn))
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

        public bool Delete(int idproduct)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Products> GetAll()
        {
            throw new NotImplementedException();
        }

        public Products GetByID(int idproduct)
        {
            throw new NotImplementedException();
        }

        public Products Update(Products products)
        {
            throw new NotImplementedException();
        }

        public Products Read(Products product)
        {
            throw new NotImplementedException();
        }
    }
}
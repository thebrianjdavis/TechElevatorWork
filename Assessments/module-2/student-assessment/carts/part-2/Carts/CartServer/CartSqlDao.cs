using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Carts
{
    public class CartSqlDao : ICartDao
    {
        private readonly string connectionString;

        public CartSqlDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Cart> GetAllCarts()
        {
            // Implement this method to pull in all carts from database
            List<Cart> carts = new List<Cart>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlQuery = "SELECT id, username, cookie_value, created FROM carts;";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Cart cart = new Cart
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Username = Convert.ToString(reader["username"]),
                            CookieValue = Convert.ToString(reader["cookie_value"]),
                            Created = Convert.ToDateTime(reader["created"])
                        };
                        carts.Add(cart);
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return carts;
        }

        public void Save(Cart newCart)
        {
            // Implement this method to save cart to database
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlQuery = "INSERT INTO carts (username, cookie_value, created) VALUES (@username, @cookie_value, @created); SELECT @@IDENTITY;";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@username", newCart.Username);
                    cmd.Parameters.AddWithValue("@cookie_value", newCart.CookieValue);
                    cmd.Parameters.AddWithValue("@created", newCart.Created);
                    newCart.Id = Convert.ToInt64(cmd.ExecuteScalar());
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
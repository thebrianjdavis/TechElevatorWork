using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Blogs
{
    public class PostSqlDao : IPostDao
    {
        private readonly string connectionString;

        public PostSqlDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Post> GetAllPosts()
        {
            // Implement this method to pull in all posts from database
            List<Post> posts = new List<Post>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlQuery = "SELECT id, name, body, published, created FROM posts;";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Post post = new Post
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = Convert.ToString(reader["name"]),
                            Body = Convert.ToString(reader["body"]),
                            IsPublished = Convert.ToBoolean(reader["published"]),
                            Created = Convert.ToDateTime(reader["created"])
                        };
                        posts.Add(post);
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return posts;
        }

        public void Save(Post newPost)
        {
            // Implement this method to save post to database
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlQuery = "INSERT INTO posts (name, body, published, created) VALUES (@name, @body, @published, @created); SELECT @@IDENTITY;";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@name", newPost.Name);
                    cmd.Parameters.AddWithValue("@body", newPost.Body);
                    cmd.Parameters.AddWithValue("@published", newPost.IsPublished);
                    cmd.Parameters.AddWithValue("@created", newPost.Created);
                    newPost.Id = Convert.ToInt64(cmd.ExecuteScalar());
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
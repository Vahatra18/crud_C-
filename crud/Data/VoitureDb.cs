using crud.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud.Data
{
    internal class VoitureDb
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=VoitureDB;Integrated Security=True";

        public static List<Voiture> GetAll()
        {
            var list = new List<Voiture>();
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Voitures", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Voiture(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3)
                            ));
                        }
                    }
                }
            }
            return list;
        }

        public static void Add(Voiture v)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("INSERT INTO Voitures (Numero, Marque, Modele) VALUES (@Numero, @Marque, @Modele)", conn))
                {
                    cmd.Parameters.AddWithValue("@Numero", v.Numero);
                    cmd.Parameters.AddWithValue("@Marque", v.Marque);
                    cmd.Parameters.AddWithValue("@Modele", v.Modele);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update(Voiture v)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("UPDATE Voitures SET Numero=@Numero, Marque=@Marque, Modele=@Modele WHERE Id=@Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Numero", v.Numero);
                    cmd.Parameters.AddWithValue("@Marque", v.Marque);
                    cmd.Parameters.AddWithValue("@Modele", v.Modele);
                    cmd.Parameters.AddWithValue("@Id", v.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("DELETE FROM Voitures WHERE Id=@Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

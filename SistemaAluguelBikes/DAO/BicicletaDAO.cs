using System.Collections.Generic;
using System.Data.SqlClient;
using ProjetoAluguelBicicletas.Models;

namespace SistemaAluguelBikes.DAO
{
    public class BicicletaDAO
    {
        private readonly string connectionString = DbConfig.ConnectionString;

        public List<Bicicleta> ListarBicicletasDisponiveis()
        {
            List<Bicicleta> bicicletas = new List<Bicicleta>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT IdBicicleta, Modelo FROM Bicicletas WHERE Status = 'Disponível'";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bicicletas.Add(new Bicicleta
                        {
                            IdBicicleta = (int)reader["IdBicicleta"],
                            Modelo = reader["Modelo"].ToString()
                        });
                    }
                }
            }

            return bicicletas;
        }
    }
}

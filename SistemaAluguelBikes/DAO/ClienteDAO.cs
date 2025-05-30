using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ProjetoAluguelBicicletas.Models;

public class ClienteDAO
{
    public void InserirCliente(Cliente cliente)
    {
        using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
        {
            conn.Open();

            string sql = "INSERT INTO Clientes (Nome, Email, Telefone) VALUES (@Nome, @Email, @Telefone)";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);

                cmd.ExecuteNonQuery();
            }
        }
    }

    public List<Cliente> ListarClientes()
    {
        var lista = new List<Cliente>();

        using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
        {
            conn.Open();
            string sql = "SELECT IdCliente, Nome, Email, Telefone FROM Clientes";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var cliente = new Cliente
                    {
                        IdCliente = (int)reader["IdCliente"],
                        Nome = reader["Nome"].ToString(),
                        Email = reader["Email"].ToString(),
                        Telefone = reader["Telefone"].ToString()
                    };

                    lista.Add(cliente);
                }
            }
        }

        return lista;
    }

}

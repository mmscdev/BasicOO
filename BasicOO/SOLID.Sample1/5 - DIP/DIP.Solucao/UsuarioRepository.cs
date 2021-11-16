using System.Data;
using BasicOO.SOLID.DIP.Solucao.Interfaces;
using Microsoft.Data.SqlClient;

//DIP = Princípio da Inversão de Dependência
namespace BasicOO.SOLID.DIP.Solucao
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void AdicionarUsuario(Usuario usuario)
        {

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "StringConexao";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO USUARIO (NOME, EMAIL CPF, DATANASCIMENTO) VALUES (@nome, @email, @cpf, @dataNas))";

                cmd.Parameters.AddWithValue("nome", usuario.Nome);
                cmd.Parameters.AddWithValue("email", usuario.Email);
                cmd.Parameters.AddWithValue("cpf", usuario.CPF);
                cmd.Parameters.AddWithValue("dataNas", usuario.DataNascimento);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

        }
    }
}
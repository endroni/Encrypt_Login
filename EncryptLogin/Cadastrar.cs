using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptLogin
{
    public class Cadastrar
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public String mensagem = "";

        public Cadastrar(String nome, String email, String senha)
        {
            // Comando SQL -- SqlCommand
            cmd.CommandText = "INSERT INTO tb_usuario (nome, email, senha) VALUES (@nome, @email, @senha)";

            //Parâmetros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);

            //Conectando com o banco -- Conexao
            try
            {
                cmd.Connection = conexao.conectar();

                //Executar comando
                cmd.ExecuteNonQuery();

                //Desconectando
                conexao.desconectar();

                //Mensagem de sucesso
                this.mensagem = "Cadastrado com sucesso";

            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de dadso!";
            }
        }
    }
}

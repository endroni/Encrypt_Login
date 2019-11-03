﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptLogin
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        //Construtor
        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-D4GI2KI\SQLEXPRESS;Initial Catalog=db_encrypt_login;User ID=sa;Password=***********";
        }

        // Método Conector
        public SqlConnection conectar()
        {
            //Verificando se a conexão já não está aberta
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        // Método Desconectar
        public void desconectar()
        {
            //Fechando a conexão caso ela esteja aberta
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}

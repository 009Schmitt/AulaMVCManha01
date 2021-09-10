using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaMVCManha01.Model
{
    public static class DBTeste
    {
        private static SqlConnection Connection { get; set; } = DBFunction.Connection;
        private static SqlCommand Cmd { get; set; } = new SqlCommand("", Connection);

        public static bool AdicionaPessoa(string nome, string cpf, string rg)
        {
            //Cmd.CommandText = "";
            //SqlCommand cmd = new SqlCommand("", Connection);
           
            // 1° Parte / insere dados na tabela Dados
            string insert = $"INSERT into dbo.Dados(Nome,Cpf,Rg) values ('{nome}','{cpf}','{rg}')";
            Cmd.CommandText = insert;
            Connection.Open();
            Cmd.ExecuteNonQuery();
            Connection.Close();
            
            // 2° Parte / seleciona o elemento recém inserido           
            string select = "SELECT Top 1 idDados from dbo.Dados Order by idDados desc";
            Cmd.CommandText = select;
            Connection.Open();
            SqlDataReader dr = Cmd.ExecuteReader();
            int idDados = 0;
            if(dr.Read())
            {
                idDados = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            Connection.Close();

            // 3° Parte / insere o elemento selecionado + os valores faltantes na tabela destino 
            insert = $"INSERT into dbo.Pessoa(idPessoa) values ({idDados})";
            Cmd.CommandText = insert;
            Connection.Open();
            Cmd.ExecuteNonQuery();
            Connection.Close();

            return true;
        }

        public static List<string[]> SelecionaPessoas()
        {
            List<string[]> lista = new List<string[]>();
            List<int> idPessoaLista = new List<int>();

            // 1° Parte \ Selecionar todos os ids da tabela pessoa
            string select = "SELECT * from dbo.Pessoa";
            Cmd.CommandText = select;
            Connection.Open();
            SqlDataReader dr = Cmd.ExecuteReader();
            while (dr.Read())
            {
                idPessoaLista.Add(Convert.ToInt32(dr[0]));
            }
            dr.Close();
            Connection.Close();

            // 2° parte \ Selecionar todas as informações do Dados onde IdPessoa Existe
            foreach (var item in idPessoaLista)
            {
                select = $"SELECT * from dbo.Dados WHERE idDados = {item}";
                Cmd.CommandText = select;
                Connection.Open();
                dr = Cmd.ExecuteReader();
                if (dr.Read())
                {
                    string[] vetor = new string[dr.FieldCount];
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        vetor[i] = dr[i].ToString();
                    }
                    lista.Add(vetor);
                }
                dr.Close();
                Connection.Close();
            }

            // 3° Parte \ Devolve para o controle
            return lista;

        }
    }
}

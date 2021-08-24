using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaMVCManha01.Model
{
    public static class DBFunction
    {
        public static SqlConnection Connection { get; set; } = new SqlConnection("Data Source=BUE205D39;Initial Catalog=BDTurmaManha;User ID=guest01;Password=@Senac2021");

        /// <summary>
        /// This function returns all elements selected in the table, the table already include dbo.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="element"></param>
        /// <returns>List(string) allSelectElements</returns>
        public static List<string> GenericUnitSelect(string element,string table)
        {
            List<string> returnElements = new List<string>();

            string select = $"SELECT {element} from dbo.{table}";
            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                returnElements.Add(dr[0].ToString());
            }
            dr.Close();
            Connection.Close();

            return returnElements;
        }

        /// <summary>
        /// This function returns all elements selected in the table, the table already include dbo. and Where must be complete
        /// </summary>
        /// <param name="element"></param>
        /// <param name="table"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public static List<string> GenericUnitSelect(string element, string table,string where)
        {
            List<string> returnElements = new List<string>();

            string select = $"SELECT {element} from dbo.{table} WHERE {where}";
            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                returnElements.Add(dr[0].ToString());
            }
            dr.Close();
            Connection.Close();

            return returnElements;
        }

        /// <summary>
        /// Execute a Non query function using the command as reference
        /// </summary>
        /// <param name="command"></param>
        public static void GenericExecute(string command)
        {
            SqlCommand cmd = new SqlCommand(command, Connection);
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

        /// <summary>
        /// Return a list of string vector with all collumns from the given table, table already includes dbo.
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<string[]> GenericSelectAll(string table)
        {
            List<string[]> lista = new List<string[]>();
            string select = $"SELECT * from dbo.{table}";
            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] vetor = new string[dr.FieldCount];
                for (int i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = dr[i].ToString();
                }
                lista.Add(vetor);
            }
            dr.Close();
            Connection.Close();
            return lista;
        }


    }
}

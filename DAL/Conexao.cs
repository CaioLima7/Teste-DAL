using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Conexao
    {
        public Conexao()
        {
            InsertManual();
        }
        public Task<string> conexao()
        {
            //string conn = "";

            //string query = "";

            //string sql = "SELECT ID, Nome, Documento, TipoDocumento";

            //using (SqlCommand command = new SqlCommand(query, cone))
            //{
            //    //command.Open();
            //    using (SqlDataReader reader = new SqlDataReader(command, query))
            //    {
            //        teste.Close();
            //    }

            //    //var asdfas = new SqlDataReader();
            //    //asdfas.Close
            //    //var lista = new List<ClienteModel>();

            //    //conn.Close
            //    //using()
            //    //using (SqlDataReader teste = new SqlDataReader())
            //    //    while (var reader = await sql.ExecuteReaderAsync())
            //    //{

            //    //}
            //    //return List

            //    return "OK";
            //}


        }


        public IList<ClienteModel> Pesquisar()
        {
            try
            {
                using (SqlDataAdapter)
                {
                    ClienteModel clienteModel = new ClienteModel();

                    while (reader.ReadAsync())
                    {
                        clienteModel.Id = (int)reader[Id].ToString();
                        clienteModel.Nome = reader[Nome].ToString();
                        clienteModel.[Documento = reader[Documento].ToString();
                    }

                }
            }
            catch (SqlException sqlEx)
            {
                throw;
            }

        }


        static void InsertManual()
        {
            string = "INSERT INTO CLIENTES VALUES ('teste', 'teste', getdate())";
        }

    }
}

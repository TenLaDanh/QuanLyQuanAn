using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataProvider
    {
        private static DataProvider instance;
        private string connectSTR = "";

        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider(); return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private DataProvider() { }
        public DataTable ExecuteQuery(string query, object[] para=null)
        {
            
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectSTR))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(query, connect);
                string[] listPara = query.Split(' ');
                int i = 0;
                if(para!=null)
                {
                    foreach(string item in listPara)
                    {
                        if(item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.Fill(data);
                connect.Close();

            }
                return data;
        }
        public int ExecuteNonQuery(string query, object[] para = null)
        {

            int data = 0;
            using (SqlConnection connect = new SqlConnection(connectSTR))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(query, connect);
                string[] listPara = query.Split(' ');
                int i = 0;
                if (para != null)
                {
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                connect.Close();

            }
            return data;
        }
        public object ExecuteScalar(string query, object[] para = null)
        {

            object data = 0;
            using (SqlConnection connect = new SqlConnection(connectSTR))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(query, connect);
                string[] listPara = query.Split(' ');
                int i = 0;
                if (para != null)
                {
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                connect.Close();

            }
            return data;
        }


    }
}

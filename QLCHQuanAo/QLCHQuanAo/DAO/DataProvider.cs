using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHQuanAo.DAO
{
    class DataProvider
    {
        // tai 1 thoi diem chi có 1 kết nối được thực hiện
        // khong can khai bao lai doi tuong dataprovider moi khi can ket noi csdl, thuc hien lenh sql
        private static DataProvider instance;//Ctrl +R+E
        internal static DataProvider Instance 
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }
            private set => instance = value; 
        }


        private string connstring = @"Data Source=DESKTOP-1EE6NGN\SQLEXPRESS02;Initial Catalog=QLShopQuanAo;Integrated Security=True";

        // thuc hien lenh select tra ve bang dl
        public DataTable ExecuteQuery(string query, object[] parameter =null)//parameter co the null
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if(parameter != null)// xu ly du lieu dua ra voi nhieu bien para cua cau lenh proc
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                conn.Close();
            }
            return data;
        }
        // tra ve so luong 
        public int ExecuteNoQuery(string query, object[] parameter = null)//parameter co the null
        {
            int data = 0; 
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameter != null)// xu ly du lieu dua ra voi nhieu bien para cua cau lenh proc
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return data;
        }
       

        // tra ve theo ham dem tai cot dau tien
        public object ExecuteScalar(string query, object[] parameter = null)//parameter co the null
        {
            object dem = 0;
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameter != null)// xu ly du lieu dua ra voi nhieu bien para cua cau lenh proc
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
               dem = cmd.ExecuteScalar();
                conn.Close();
            }
            return dem;
        }
    }
}

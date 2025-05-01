using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DataProvider
    {
        // Đường dẫn kết nối đến cơ sở dữ liệu
        //Data Source=MSI66\MSSQLSERVER01;Initial Catalog=QLST;Integrated Security=True;Trust Server Certificate=True
        private SqlConnection _conn = new SqlConnection("Data Source=MSI66\\MSSQLSERVER01;Initial Catalog=QLST;Integrated Security=True");
        private Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();

        public void addParam(string para, dynamic value)
        {
            data.Add(para, value);
        }

        public int queryExecute(string query)
        {
            try
            {
                _conn.Open();

                SqlCommand command = new SqlCommand(query, _conn);
                command.CommandType = CommandType.StoredProcedure;

                int numOfRows = command.ExecuteNonQuery();



                _conn.Close();

                return numOfRows;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataTable queryExecuteAdapter(string proc, Dictionary<string, dynamic> dt = null)
        {
            try
            {
                if (dt != null)
                {
                    data = dt;
                }

                _conn.Open();

                SqlCommand command = new SqlCommand(proc, _conn);

                command.CommandType = CommandType.StoredProcedure;
                if (data.Count > 0)
                {
                    foreach (var item in data)
                    {
                        SqlParameter p = new SqlParameter("@" + item.Key, item.Value);
                        p.Direction = ParameterDirection.Input;
                        command.Parameters.Add(p);
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable res = new DataTable();

                adapter.Fill(res);

                _conn.Close();

                data.Clear();

                return res;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Lỗi Data: {e.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

    }
}

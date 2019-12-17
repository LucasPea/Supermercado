using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class dbClass
{
    private string connString;
    private SqlConnection sqlConn;

    public dbClass()
    {
        this.connString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
    }
    public DataSet ExecuteQuery(string strQuery)
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        try
        {
            using (this.sqlConn = new SqlConnection(this.connString))
            {
                SqlCommand cmd = new SqlCommand(strQuery)
                {
                    Connection = this.sqlConn,
                    CommandType = CommandType.Text
                };
                this.sqlConn.Open();
                da.SelectCommand = cmd;
                da.Fill(ds);

                da.Dispose();
                cmd.Dispose();
                this.sqlConn.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message); 
        }
        return ds;
    }
}

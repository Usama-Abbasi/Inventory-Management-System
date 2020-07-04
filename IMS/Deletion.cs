using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    class Deletion
    {
        public void delete(object id, string proc,string param)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param,id);
                MainClass.connection.Open();
                cmd.ExecuteNonQuery();
                MainClass.connection.Close();
                MainClass.showMessage("Deleted from System Successfully", "Successfully....", "Success");
            }
            catch (Exception e)
            {
                MainClass.connection.Close();
                MainClass.showMessage(e.Message, "Error", "Error");
            }


        }
    }
}

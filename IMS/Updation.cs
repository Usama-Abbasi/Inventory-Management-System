using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    class Updation
    {
        public void updateUser(int id,string name, string username, string pass, string phone, string email,Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateUsers", MainClass.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", pass);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", id);
                MainClass.connection.Open();
                cmd.ExecuteNonQuery();
                MainClass.connection.Close();
                MainClass.showMessage(name + "Updated to the System Successfully", "Successfully....", "Success");
            }
            catch (Exception e)
            {
                MainClass.connection.Close();
                MainClass.showMessage(e.Message, "Error", "Error");
            }


        }
        public void updateCat(int id,string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCategory", MainClass.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isActive", status);
                cmd.Parameters.AddWithValue("@id", id);

                MainClass.connection.Open();
                cmd.ExecuteNonQuery();
                MainClass.connection.Close();
                MainClass.showMessage(name +"  " +"Updated  Successfully", "Successfully....", "Success");
            }
            catch (Exception e)
            {
                MainClass.connection.Close();
                MainClass.showMessage(e.Message, "Error", "Error");
            }


        }
        public void updateProduct(int id,string product, string barcode, float money,int catID ,DateTime? date=null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateProduct", MainClass.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", product);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                cmd.Parameters.AddWithValue("@price", money);
                if (date == null)
                {
                    cmd.Parameters.AddWithValue("@expiry", DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue("@expiry", date);

                }
                cmd.Parameters.AddWithValue("@catID", catID);
                cmd.Parameters.AddWithValue("@id", catID);
                MainClass.connection.Open();
                cmd.ExecuteNonQuery();
                MainClass.connection.Close();
                MainClass.showMessage(product + " " + "Updated Successfully", "Successfully....", "Success");
            }
            catch (Exception e)
            {
                MainClass.connection.Close();
                MainClass.showMessage(e.Message, "Error", "Error");
            }


        }
        public void updateSupplier(int supId,string compnay, string contactperson, string phone1, string address, Int16 status, string phone2 = null, string ntn = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateSupplier", MainClass.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company", compnay);
                cmd.Parameters.AddWithValue("@contactPerson", contactperson);
                cmd.Parameters.AddWithValue("@phone1", phone1);
                if (phone2 == null)
                {
                    cmd.Parameters.AddWithValue("@phone2", DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue("@phone2", phone2);

                }
                cmd.Parameters.AddWithValue("@address", address);
                if (ntn == null)
                {
                    cmd.Parameters.AddWithValue("@ntn", DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue("@ntn", ntn);

                }
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id",supId);
                
                MainClass.connection.Open();
                cmd.ExecuteNonQuery();
                MainClass.connection.Close();
                MainClass.showMessage(compnay + " " + "Updated Successfully", "Successfully....", "Success");
            }
            catch (Exception e)
            {
                MainClass.connection.Close();
                MainClass.showMessage(e.Message, "Error", "Error");
            }


        }
    }
}

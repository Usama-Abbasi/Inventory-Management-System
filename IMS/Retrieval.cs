using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    class Retrieval
    {
        public void showUser(DataGridView gv, DataGridViewColumn idGV, DataGridViewColumn nameGV, DataGridViewColumn usernameGV, DataGridViewColumn passGV, DataGridViewColumn emailGV, DataGridViewColumn phoneGV, DataGridViewColumn statusGV,string data=null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getUsersData", MainClass.connection);
                }
                else
                {
                    cmd = new SqlCommand("st_getUsersDataLike", MainClass.connection);
                    cmd.Parameters.AddWithValue("@data", data);
                }
               
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                idGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Name"].ToString();
                usernameGV.DataPropertyName = dt.Columns["User Name"].ToString();
                passGV.DataPropertyName = dt.Columns["Password"].ToString();
                emailGV.DataPropertyName = dt.Columns["Email"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;

            }
            catch (Exception e)
            {
            }

        }
        public void showCategories(DataGridView gv, DataGridViewColumn idGV, DataGridViewColumn nameGV,DataGridViewColumn statusGV)
        {
            try
            {
                SqlCommand cmd= new SqlCommand("st_getCategoriesData", MainClass.connection);
                
              

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                idGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Category"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;

            }
            catch (Exception e)
            {
                MainClass.showMessage("Error to load Data", "Error", "Error");
            }

        }
        public void getlist(string proc, ComboBox cb,string displaymember,string valuemember)
        {
            try
            {
                cb.Items.Clear();

                cb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc, MainClass.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select...." };
                dt.Rows.InsertAt(dr,0);
                cb.DisplayMember = displaymember;
                cb.ValueMember = valuemember;
                cb.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
        }
        public void showProduct(DataGridView gv, DataGridViewColumn proidGV, DataGridViewColumn productGV, DataGridViewColumn barcodeGV, DataGridViewColumn expiryGV, DataGridViewColumn priceGV, DataGridViewColumn catGV, DataGridViewColumn catidGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductData", MainClass.connection);



                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proidGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                productGV.DataPropertyName = dt.Columns["Product"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["BarCode"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry"].ToString();
                priceGV.DataPropertyName = dt.Columns["Price"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                catidGV.DataPropertyName = dt.Columns["Category ID"].ToString();
                gv.DataSource = dt;

            }
            catch (Exception e)
            {
                MainClass.showMessage("Error to load Data", "Error", "Error");
            }

        }
        public static int USer_ID
        {
            get;
            private set;
        }
        public static string EMP_NAME
        {
            get;
            private set;
        }
        private static string user_name=null, pass_word=null;
        private static bool checklogin;
        public static bool getUserDetail(string username, string pass)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getUserDetail", MainClass.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", username);
                cmd.Parameters.AddWithValue("@pass", pass);
                MainClass.connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checklogin = true;
                    while (dr.Read())
                    {
                        USer_ID = Convert.ToInt32(dr["ID"].ToString());
                        EMP_NAME = dr["Name"].ToString();
                        user_name = dr["Username"].ToString();
                        pass_word = dr["Password"].ToString();
                    }

                }
                else
                {
                    checklogin = false;
                    if (username != null && pass != null)
                    {
                        if (user_name != username && pass_word == pass)
                        {
                            MainClass.showMessage("Invalied Username", "Error", "Error");
                        }
                        else if (user_name == username && pass_word != pass)
                        {
                            MainClass.showMessage("Invalied Password", "Error", "Error");
                        }
                       else  if (user_name != username && pass_word != pass)
                        {
                            MainClass.showMessage("Invalied Username and Password", "Error", "Error");
                        }
                    }
                }
                MainClass.connection.Close();
            }
            catch(Exception ex)
            {
                MainClass.connection.Close();
                MainClass.showMessage("Error in Login", "Error", "Error");
            }
            return checklogin;
        }
        public void showSupplier(DataGridView gv, DataGridViewColumn idGV, DataGridViewColumn companyGV, DataGridViewColumn contactpersonGV, DataGridViewColumn phone1GV, DataGridViewColumn phone2GV, DataGridViewColumn addressGV, DataGridViewColumn statusGV, DataGridViewColumn ntnGV)
        {
            try
            {
                SqlCommand cmd= new SqlCommand("st_geSupplierData", MainClass.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                idGV.DataPropertyName = dt.Columns["ID"].ToString();
                companyGV.DataPropertyName = dt.Columns["Company"].ToString();
                contactpersonGV.DataPropertyName = dt.Columns["Contact Person"].ToString();
                phone1GV.DataPropertyName = dt.Columns["Phone 1"].ToString();
                phone2GV.DataPropertyName = dt.Columns["Phone 2"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                ntnGV.DataPropertyName = dt.Columns["NTN"].ToString();
                gv.DataSource = dt;

            }
            catch (Exception e)
            {
                MainClass.showMessage("Unable to load Suppliers", "Error", "Error");
            }

        }
        private string[] productData = new string[4];
        public string[] getProductWRTBarcode(string barcode)
        {
            try
            {
               
                SqlCommand cmd = new SqlCommand("st_getProductByBarCode", MainClass.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue ("@barcode", barcode);
                MainClass.connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while(dr.Read())
                    {
                        productData[0] = dr[0].ToString();
                        productData[1] = dr[1].ToString();
                        productData[2] = dr[2].ToString();
                        productData[3] = dr[2].ToString();

                    }
                }
                else
                {
                    
                }
                MainClass.connection.Close();
            }
            catch (Exception ex)
            {
                MainClass.connection.Close();
            }
            return productData;
        }
    }
}

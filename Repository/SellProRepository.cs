using IndiaMart.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace IndiaMart.Repository
{
    public class SellProRepository
    {
        //private SqlConnection con;

        //private void connection()
        //{
        //    string constr = ConfigurationManager.ConnectionStrings["getconn"].ToString();
        //    con = new SqlConnection(constr);

        //}

        public List<DisplaySellerProductVM> DisplaySellerProduct(int SellerID, string ConStr)
        {
            SqlConnection Con = new SqlConnection(ConStr);
            List<DisplaySellerProductVM> DisplaySellerProduct = new List<DisplaySellerProductVM>();

            SqlCommand com = new SqlCommand("DisplaySellerProduct", Con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@sid", SellerID);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            Con.Open();
            da.Fill(dt);
            Con.Close();
            foreach (DataRow dr in dt.Rows)
            {

                DisplaySellerProduct.Add(

                    new DisplaySellerProductVM
                    {
                        SellProId = Convert.ToInt32(dr["SellProID"]),
                        SellerID = Convert.ToInt32(dr["SellerID"]),
                        ProductName = (dr["ProductName"].ToString()),
                        BrandName = Convert.ToString(dr["BrandName"]),
                        Price = Convert.ToDecimal(dr["Price"])

                    }
                    );
            }

            return DisplaySellerProduct;
        }

        public bool DeleteProductFromSeller(int SellProID, string ConStr)
        {

            SqlConnection Con = new SqlConnection(ConStr);
            SqlCommand com = new SqlCommand("DeleteProductFromSeller", Con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@spid", SellProID);

            Con.Open();
            int i = com.ExecuteNonQuery();
            Con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {

                return false;
            }
        }

        public bool AddSellPro(SellPro obj, string ConStr)
        {

            SqlConnection Con = new SqlConnection(ConStr);
            SqlCommand com = new SqlCommand("AddSellPro", Con);
            com.CommandType = CommandType.StoredProcedure;
            //  com.Parameters.AddWithValue("@sid", obj.);
            com.Parameters.AddWithValue("@sid", obj.SellerID);
            com.Parameters.AddWithValue("@pid", obj.ProductID);


            Con.Open();
            int i = com.ExecuteNonQuery();
            Con.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }


        }
    }

}

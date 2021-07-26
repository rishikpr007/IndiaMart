using IndiaMart.Models;
using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace IndiaMart.Repository
{
    public class SellerRepository
    {
        //private SqlConnection con;

        //private void connection()
        //{
        //    string constr = ConfigurationManager.ConnectionStrings["getconn"].ToString();
        //    con = new SqlConnection(constr);

        //}

        public bool AddSeller(Seller obj, string ConStr)
        {
            SqlConnection Con = new SqlConnection(ConStr);
            SqlCommand com = new SqlCommand("AddSeller", Con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@sname", obj.SellerName);
            com.Parameters.AddWithValue("@oname", obj.OwnerName);

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

        public List<Seller> GetAllSeller(string ConStr)
        {
            SqlConnection Con = new SqlConnection(ConStr);
            List<Seller> SellerList = new List<Seller>();


            SqlCommand com = new SqlCommand("AllSeller", Con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            Con.Open();
            da.Fill(dt);
            Con.Close();
            foreach (DataRow dr in dt.Rows)
            {

                SellerList.Add(

                    new Seller
                    {

                        SellerID = Convert.ToInt32(dr["SellerID"]),
                        SellerName = Convert.ToString(dr["SellerName"]),
                        OwnerName = Convert.ToString(dr["OwnerName"]),

                    }
                    );
            }

            return SellerList;
        }


        public bool UpdateSeller(Seller obj, string ConStr)
        {
            SqlConnection Con = new SqlConnection(ConStr);

            SqlCommand com = new SqlCommand("UpdateSeller", Con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@sid", obj.SellerID);
            com.Parameters.AddWithValue("@sname", obj.SellerName);
            com.Parameters.AddWithValue("@oname", obj.OwnerName);
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

        public bool DeleteSeller(int SellerID, string ConStr)
        {

            SqlConnection Con = new SqlConnection(ConStr);
            SqlCommand com = new SqlCommand("DeleteSeller", Con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@sid", SellerID);

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



        public List<Seller> SellerName(int SellerID, string ConStr)
        {
            SqlConnection Con = new SqlConnection(ConStr);
            List<Seller> SellerName = new List<Seller>();


            SqlCommand com = new SqlCommand("SellerName", Con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@sid", SellerID);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            Con.Open();
            da.Fill(dt);
            Con.Close();
            foreach (DataRow dr in dt.Rows)
            {

                SellerName.Add(

                    new Seller
                    {
                        SellerID = Convert.ToInt32(dr["SellerID"]),
                        SellerName = (dr["SellerName"].ToString()),
                    }
                    );
            }

            return SellerName;
        }



    }

}

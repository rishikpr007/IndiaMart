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
    public class ProductRepository
    {
        //private SqlConnection con;

        //private void connection()
        //{
        //    string constr = ConfigurationManager.ConnectionStrings["getconn"].ToString();
        //    con = new SqlConnection(constr);

        //}

        public bool AddProduct(Product obj, string ConStr)
        {

            SqlConnection Con = new SqlConnection(ConStr);
            SqlCommand com = new SqlCommand("AddProduct", Con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@pname", obj.ProductName);
            com.Parameters.AddWithValue("@bname", obj.BrandName);
            com.Parameters.AddWithValue("@price", obj.Price);

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

        public List<Product> GetAllProduct(string ConStr)
        {
            SqlConnection Con = new SqlConnection(ConStr);
            List<Product> ProductList = new List<Product>();


            SqlCommand com = new SqlCommand("AllProduct", Con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            Con.Open();
            da.Fill(dt);
            Con.Close();
            foreach (DataRow dr in dt.Rows)
            {

                ProductList.Add(

                    new Product
                    {

                        ProductID = Convert.ToInt32(dr["ProductID"]),
                        ProductName = Convert.ToString(dr["ProductName"]),
                        BrandName = Convert.ToString(dr["BrandName"]),
                        Price = Convert.ToDecimal(dr["Price"]),
                    }
                    );
            }

            return ProductList;
        }


        public bool UpdateProduct(Product obj, String ConStr)
        {

            SqlConnection Con = new SqlConnection(ConStr);
            SqlCommand com = new SqlCommand("UpdateProduct", Con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@pid", Convert.ToInt32(obj.ProductID));
            com.Parameters.AddWithValue("@pname", obj.ProductName);
            com.Parameters.AddWithValue("@bname", obj.BrandName);
            com.Parameters.AddWithValue("@price", Convert.ToDecimal(obj.Price));

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

        public bool DeleteProduct(int ProductID, String ConStr)
        {

            SqlConnection Con = new SqlConnection(ConStr);
            SqlCommand com = new SqlCommand("DeleteProduct", Con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@pid", ProductID);

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

        public List<GetProductVM> GetAllProductList(String ConStr)
        {
            SqlConnection Con = new SqlConnection(ConStr);
            List<GetProductVM> ProductList = new List<GetProductVM>();


            SqlCommand com = new SqlCommand("GetAllProduct", Con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            Con.Open();
            da.Fill(dt);
            Con.Close();
            foreach (DataRow dr in dt.Rows)
            {

                ProductList.Add(

                    new GetProductVM
                    {

                        ProductID = Convert.ToInt32(dr["ProductID"]),
                        ProductName = Convert.ToString(dr["ProductName"]),

                    }
                    );
            }

            return ProductList;
        }



    }

}

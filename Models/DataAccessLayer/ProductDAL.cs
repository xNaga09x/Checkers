using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;

namespace Tema3.Models
{
    public class PersonDAL
    {
        //public ObservableCollection<Product> GetAllProducts()
        //{
        //    SqlConnection con = DALHelper.Connection;
        //    //try
        //    //{
        //    //    SqlCommand cmd = new SqlCommand("GetAllProducts", con);
        //    //    ObservableCollection<Product> result = new ObservableCollection<Product>();
        //    //    cmd.CommandType = CommandType.StoredProcedure;
        //    //    con.Open();
        //    //    SqlDataReader reader = cmd.ExecuteReader();
        //    //    while (reader.Read())
        //    //    {
        //    //        Product p = new Product();
        //    //        p.ProductID = (int)(reader[0]);
        //    //        p.Name = reader.GetString(1);
        //    //        p.Barcode = (int)(reader[2]);
        //    //        p.Category = reader.GetString(3);
        //    //        p.Producer = reader.GetString(4);
        //    //        result.Add(p);
        //    //    }
        //    //    reader.Close();
        //    //    return result;
        //    //}
        //    //finally
        //    //{
        //    //    con.Close();
        //    //}
        //}

        //public ObservableCollection<Product> GetAllPersonsWithNoPhone()
        //{
        //    using (SqlConnection con = DALHelper.Connection)
        //    {
        //        SqlCommand cmd = new SqlCommand("GetAllPersonsWithNoPhone", con);
        //        ObservableCollection<Product> result = new ObservableCollection<Product>();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        con.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            result.Add(
        //                new Product()
        //                {
        //                    ProductID = reader["ProductID"] as int?,
        //                    Name = reader["Name"].ToString(),
        //                    Barcode = (int)(reader["Barcode"] as int?),
        //                    Producer = reader["Producer"].ToString(),
        //                    Category = reader["Category"].ToString()
        //                }
        //            );
        //        }
        //        reader.Close();
        //        return result;
        //    }
        //}

        //public void AddPerson(Product product)
        //{
        //    using (SqlConnection con = DALHelper.Connection)
        //    {
        //        SqlCommand cmd = new SqlCommand("AddPerson", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        SqlParameter paramNume = new SqlParameter("@name", product.Name);
        //        SqlParameter paramBarcode = new SqlParameter("@barcode", product.Barcode); ;
        //        SqlParameter paramProducer = new SqlParameter("@producer", product.Producer);
        //        SqlParameter paramCategory = new SqlParameter("@category", product.Category); 
        //        SqlParameter paramID = new SqlParameter("@id", product.ProductID); 
        //        if (product.Barcode.Equals(null))
        //            paramBarcode = new SqlParameter("@b", DBNull.Value);
        //        else
        //            paramBarcode = new SqlParameter("@b", product.Barcode);
        //        SqlParameter paramIdPersoana = new SqlParameter("@i", SqlDbType.Int);
        //        paramIdPersoana.Direction = ParameterDirection.Output;
        //        cmd.Parameters.Add(paramNume);
        //        cmd.Parameters.Add(paramBarcode);
        //        cmd.Parameters.Add(paramID);
        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //        product.ProductID = paramID.Value as int?;
        //    }
        //}

        //public void DeletePerson(Product product)
        //{
        //    using (SqlConnection con = DALHelper.Connection)
        //    {
        //        SqlCommand cmd = new SqlCommand("DeletePerson", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        SqlParameter paramID= new SqlParameter("@id", product.ProductID);
        //        cmd.Parameters.Add(paramID);
        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //}

        //public void ModifyPerson(Product product)
        //{
        //    using (SqlConnection con = DALHelper.Connection)
        //    {
        //        SqlCommand cmd = new SqlCommand("ModifyPerson", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        SqlParameter paramID = new SqlParameter("@ID", product.ProductID);
        //        SqlParameter paramName = new SqlParameter("@name", product.Name);
        //        SqlParameter paramBarcode = new SqlParameter("@barcode", product.Barcode);
        //        SqlParameter paramCategory= new SqlParameter("@category", product.Category);
        //        SqlParameter paramProducer = new SqlParameter("@producer", product.Producer);
        //        paramName.ParameterName = "@name";
        //        if (string.IsNullOrEmpty(product.Name))
        //        {
        //            paramName.Value = DBNull.Value;
        //        }
        //        else
        //        {
        //            paramName.Value = product.Name;
        //        }
        //        cmd.Parameters.Add(paramID);
        //        cmd.Parameters.Add(paramName);
        //        cmd.Parameters.Add(paramBarcode);
        //        cmd.Parameters.Add(paramCategory);
        //        cmd.Parameters.Add(paramProducer);
        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //}
    }
}

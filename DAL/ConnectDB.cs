using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ConnectDB
    {
        public static DataTable Getcustomer()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Constants.strCon);

            connection.Open();

            SqlCommand cmd = new SqlCommand("sp_getallcustomers", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            dt.Load(cmd.ExecuteReader());

            if (connection.State != ConnectionState.Closed)
                connection.Close();


            return dt;

        }

        public static void Addcustomer(Customer customer)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Constants.strCon);
            

            SqlCommand cmd = new SqlCommand("sp_insert", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@firstname", customer.firstname);
            prm[1] = new SqlParameter("@lastname", customer.lastname);
            prm[2] = new SqlParameter("roomid", customer.roomid);

            cmd.Parameters.AddRange(prm);

            connection.Open();

            cmd.ExecuteNonQuery();

            if (connection.State != ConnectionState.Closed)
                connection.Close();


        }
        public static DataTable FilterfromDatabase(Customer customer)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Constants.strCon);
            connection.Open();

            SqlCommand cmd = new SqlCommand("sp_filter", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@firstname", customer.firstname);
            prm[1] = new SqlParameter("@lastname", customer.lastname);
            prm[2] = new SqlParameter("@roomid", customer.roomid);

            cmd.Parameters.AddRange(prm);
            dt.Load(cmd.ExecuteReader());

            if (connection.State != ConnectionState.Closed)
                connection.Close();

            return dt;


        }

        public static DataTable SqlDataAdapter()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Constants.strCon);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from customerservice", connection);
            adapter.Fill(dt);

            return dt;

        }


        public static void Updatecustomer(DataTable dt)
        {
            SqlConnection connection = new SqlConnection(Constants.strCon);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from customerservice",connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(dt);

        }
        public static void AddUpdate(Customer customer)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Constants.strCon);
            connection.Open();

            SqlCommand cmd = new SqlCommand("sp_update", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@customerid", customer.customerid);
            prm[1] = new SqlParameter("@firstname", customer.firstname);
            prm[2] = new SqlParameter("@lastname", customer.lastname);
            prm[3] = new SqlParameter("roomid", customer.roomid);

            cmd.Parameters.AddRange(prm);
            cmd.ExecuteNonQuery();

            if (connection.State != ConnectionState.Closed)
                connection.Close();


        }
        public static void Delete(Customer customer)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Constants.strCon);


            SqlCommand cmd = new SqlCommand("sp_delete", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prm = new SqlParameter("@customerid",customer.customerid);

            cmd.Parameters.Add(prm);

            connection.Open();

            cmd.ExecuteNonQuery();

            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }
    }
}

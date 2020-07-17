using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Rental
{
    public class DBLink
    {
        private readonly string conString = @"Data Source=LAPTOP-REIR8099\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly SqlConnection con;

        public DBLink() //Connecting to DB
        {
            con = new SqlConnection(conString);
        }

        public string currTable;

        public DataTable CallCustomers()
        {
            con.Open();

            DataTable customersDT = new DataTable();

            //Clears the datagrid
            customersDT.Clear();

            //Creating appropriate table
            customersDT.Columns.Add("Customer ID");
            customersDT.Columns.Add("First Name");
            customersDT.Columns.Add("Last Name");
            customersDT.Columns.Add("Phone");
            customersDT.Columns.Add("Address");

            //Retreiving data from DB
            string query = @"Select * from Customer order by LastName";

            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                customersDT.Rows.Add(
                    reader["CustID"],
                    reader["FirstName"],
                    reader["LastName"],
                    reader["Phone"],
                    reader["Address"]
                    );
            }

            reader.Close();
            con.Close();

            return customersDT;
        }

        public DataTable CallRents()
        {
            con.Open();

            DataTable RentsDT = new DataTable();

            //Clears the datagrid
            RentsDT.Clear();

            //Creating appropriate table
            RentsDT.Columns.Add("Rent ID");
            RentsDT.Columns.Add("Customer ID");
            RentsDT.Columns.Add("Movie ID");
            RentsDT.Columns.Add("Date Rented");
            RentsDT.Columns.Add("Date Returned");

            //Retreiving data from DB
            string query = @"Select * from RentedMovies order by DateRented";

            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                RentsDT.Rows.Add(
                    reader["RMID"],
                    reader["MovieIDFK"],
                    reader["CustIDFK"],
                    reader["DateRented"],
                    reader["DateReturned"]
                    );
            }

            reader.Close();
            con.Close();

            return RentsDT;
        }

        public DataTable CallMovies()
        {
            con.Open();

            DataTable MoviestDT = new DataTable();

            //Clears the datagrid
            MoviestDT.Clear();

            //Creating appropriate table
            MoviestDT.Columns.Add("Movie ID");
            MoviestDT.Columns.Add("Title");
            MoviestDT.Columns.Add("Year Released");
            MoviestDT.Columns.Add("Plot");
            MoviestDT.Columns.Add("Rating");
            MoviestDT.Columns.Add("Genre");
            MoviestDT.Columns.Add("Rental Cost");
            MoviestDT.Columns.Add("Copies");

            //Retreiving data from DB
            string query = @"Select * from Movies order by Title";

            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                MoviestDT.Rows.Add(
                    reader["MovieID"],
                    reader["Title"],
                    reader["Year"],
                    reader["Plot"],
                    reader["Rating"],
                    reader["Genre"],
                    reader["Rental_Cost"],
                    reader["Copies"]
                    );
            }

            reader.Close();
            con.Close();

            return MoviestDT;
        }

    }
}

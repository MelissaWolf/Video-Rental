using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Rental
{
    public class DBLink
    {
        private readonly string conString = @"Data Source=LAPTOP-REIR8099\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True;
                                              Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly SqlConnection con;

        public DBLink() //Connecting to DB
        {
            con = new SqlConnection(conString);
        }

        public string DBLinkCheck() //Connecting to DB
        {
            return con.Database;
        }

        public string currTable;

        public void PriceUpdate()
        { //Updates Movies Price is Needed

            string costUpdate = "UPDATE Movies SET Rental_Cost = 2 WHERE Year < " + (DateTime.Now.Year - 5) + " OR Year IS NULL;";

            using (SqlCommand update = new SqlCommand(costUpdate, con))
            {
                con.Open();

                //Run the Query
                update.ExecuteNonQuery();

                con.Close();
            }
        }

        public DataTable CallCustomers()
        {
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
            string query = @"SELECT * FROM Customer ORDER BY LastName;";

            SqlCommand command = new SqlCommand(query, con);

            con.Open();

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
        } //Call Customers Ends

        public DataTable CallRents(string view)
        {
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
            string query = @"SELECT * FROM RentedMovies " + view + "ORDER BY DateRented;";

            SqlCommand command = new SqlCommand(query, con);

            con.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                RentsDT.Rows.Add(
                    reader["RMID"],
                    reader["CustIDFK"],
                    reader["MovieIDFK"],
                    reader["DateRented"],
                    reader["DateReturned"]
                    );
            }

            reader.Close();
            con.Close();

            return RentsDT;
        } //CallRents Ends

        public DataTable CallMovies()
        {
            //Updates Price everytime Table is called
            PriceUpdate();

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
            string query = @"SELECT * FROM Movies ORDER BY Title;";

            SqlCommand command = new SqlCommand(query, con);

            con.Open();

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
        } //CallMovies Ends

        public void GetRentInfo(string custId, string movieId,
                                out string fName, out string lName, out string phone, out string home,
                                out string title, out string year, out string plot, out string rating, out string genre, out string cost, out string copies)
        {
            fName = "";
            lName = "";
            phone = "";
            home = "";

            title = "";
            year = "";
            plot = "";
            rating = "";
            genre = "";
            cost = "";
            copies = "";

            //Retreiving data from DB
            string custQuery = @"SELECT FirstName, LastName, Phone, Address FROM Customer WHERE CustID = " + custId + ";";
            string movieQuery = @"SELECT Title, Year, Plot, Rating, Genre, Rental_Cost, Copies FROM Movies WHERE MovieID = " + movieId + ";";

            SqlCommand commandCust = new SqlCommand(custQuery, con);
            SqlCommand commandMovi = new SqlCommand(movieQuery, con);

            con.Open();

            try
            {
                //Getting Customer Info
                using (SqlDataReader readingCust = commandCust.ExecuteReader())
                {
                    while (readingCust.Read())
                    {
                        fName = readingCust["FirstName"].ToString();
                        lName = readingCust["LastName"].ToString();
                        phone = readingCust["Phone"].ToString();
                        home = readingCust["Address"].ToString();
                    }
                    readingCust.Close();
                }

                //Getting Movie Info
                using (SqlDataReader readingMovi = commandMovi.ExecuteReader())
                {
                    while (readingMovi.Read())
                    {
                        title = readingMovi["Title"].ToString();
                        year = readingMovi["Year"].ToString();
                        plot = readingMovi["Plot"].ToString();
                        rating = readingMovi["Rating"].ToString();
                        genre = readingMovi["Genre"].ToString();
                        cost = readingMovi["Rental_Cost"].ToString();
                        copies = readingMovi["Copies"].ToString();

                    }
                    readingMovi.Close();
                }
            }
            catch
            {
            }

            con.Close();
        } //GetRentInof Ends

        public string MovieErrorCheck(string checkResult, string rate, string title, string year, string copies, string genre, string plot)
        {

            string stringError = "NA";

            if (rate.Length > 15)
            {
                stringError = "The Text '" + rate + "' is not appropriate as it is too long. Please shorten it.";
            }
            else if (title.Length > 50)
            {
                stringError = "The Text '" + title + "' is not appropriate as it is too long. Please shorten it.";
            }
            else if (year.Length > 4)
            {
                stringError = "The Text '" + year + "' is not appropriate as it is too long. Please shorten it.";
            }

            foreach (char c in year) //foreach from jakobbotsch from stack overflow
            {
                if (c < '0' || c > '9')
                {
                    stringError = "The Text '" + year + "' is not appropriate for the released date. Numbers ONLY!";
                    break;
                }
            }

            if (copies.Length > 2)
            {
                stringError = "The Text '" + copies + "' is not appropriate as it is too long. Please shorten it."; //We don't own more then 99 of one movie 
            }
            else if (genre.Length > 30)
            {
                stringError = "The Text '" + genre + "' is not appropriate as it is too long. Please shorten it.";
            }
            else if (plot.Length > 255)
            {
                stringError = "The Text '" + plot + "' is not appropriate as it is too long. Please shorten it.";
            }

            return stringError;
        }


        //Adding to DataBase
        public string AddCustomer(string custID, string fName, string lName, string phone, string address)
        {
            string addingResult = "Data Successfully Inserted into " + currTable;
            string stringError = "NA";

            string NewEntry = "INSERT INTO Customer (FirstName, LastName, Phone, Address) " +
                    "VALUES(@FirstName, @LastName, @Phone, @Address);";

            string[] texts = { fName, lName, phone, address };

            for (int i = 0; i < texts.Length; i++)
            {

                if (texts[i].Length > 30)
                {

                    stringError = "The Text '" + texts[i] + "' is not appropriate as it is too long. Please shorten it.";
                    addingResult = stringError;
                    break;
                }
            }

            foreach (char c in phone) //foreach from jakobbotsch from stack overflow
            {
                if (c < '0' || c > '9')
                {
                    stringError = "The Text '" + phone + "' is not appropriate for a phone number. Numbers ONLY!";
                    addingResult = stringError;
                    break;
                }
            }

            if (addingResult != stringError) //All Text Boxes are appropriate
            {
                //This puts the Parameters into the Code so that the Data in the Text Boxes is Added to the Database
                using (SqlCommand newdata = new SqlCommand(NewEntry, con))
                {
                    newdata.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = fName;
                    newdata.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lName;
                    newdata.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = phone;
                    newdata.Parameters.Add("@Address", SqlDbType.NVarChar).Value = address;

                    con.Open();

                    //Run the Query
                    newdata.ExecuteNonQuery();

                    con.Close();
                }
            }

            return addingResult;
        } //AddCustomer Ends

        public string AddRent(string custID, string movieID)
        {
            string addingResult = "";

            string confirmEntryCust = "SELECT COUNT(CustID) FROM Customer WHERE CustID = " + custID + ";";
            int CustIDFK = 0;
            string confirmEntryMovie = "SELECT COUNT(MovieID) FROM Movies WHERE MovieID = " + movieID + ";";
            int MovieIDFK = 0;

            SqlCommand checkCust = new SqlCommand(confirmEntryCust, con);
            SqlCommand checkMovies = new SqlCommand(confirmEntryMovie, con);

            con.Open();

            //Run the Queries
            CustIDFK = Convert.ToInt32(checkCust.ExecuteScalar());
            MovieIDFK = Convert.ToInt32(checkMovies.ExecuteScalar());

            con.Close();

            if (CustIDFK > 0 && MovieIDFK > 0) //Checks that both Foreign Keys Exist
            {
                //Updates Price quickly
                PriceUpdate();

                string getPrice = "SELECT Rental_Cost FROM Movies WHERE MovieID = " + movieID + " OR Year IS NULL;";

                string NewEntry = "INSERT INTO RentedMovies (CustIDFK, MovieIDFK, DateRented) " +
                        "VALUES(@CustIDFK, @MovieIDFK, @DateRented);";

                //This puts the Parameters into the Code so that the Data in the Text Boxes is Added to the Database
                using (SqlCommand newdata = new SqlCommand(NewEntry, con))
                {
                    newdata.Parameters.Add("@CustIDFK", SqlDbType.Int).Value = custID;
                    newdata.Parameters.Add("@MovieIDFK", SqlDbType.Int).Value = movieID;
                    newdata.Parameters.Add("@DateRented", SqlDbType.DateTime).Value = DateTime.Now;

                    con.Open();

                    //Run the Query
                    newdata.ExecuteNonQuery();

                    con.Close();
                }

                int cost = 0;

                SqlCommand commandCost = new SqlCommand(getPrice, con);

                con.Open();

                //Getting Movie Price
                using (SqlDataReader readingCost = commandCost.ExecuteReader())
                {
                    while (readingCost.Read())
                    {
                        cost = Convert.ToInt32(readingCost["Rental_Cost"]);
                    }
                    readingCost.Close();
                    con.Close();
                }

                addingResult = "Movie Successfully Rented. Price is $" + cost + ".";
            }
            else
            {
                if (CustIDFK <= 0 && MovieIDFK > 0)
                {
                    addingResult = "Customer ID & Movie ID is Invalid!";
                }
                else if (CustIDFK <= 0)
                {
                    addingResult = "Customer ID is Invalid!";
                }
                else
                {
                    addingResult = "Movie ID is Invalid!";
                }
            }
            return addingResult;
        } //AddRent Ends

        public string RentIn(string rentsID)
        {
            string inResult = "Movie Successfully Returned!";

            string Update = "UPDATE RentedMovies SET DateReturned = @DateReturned WHERE RMID = " + rentsID + ";";

            //This puts the Parameters into the Code so that the Data in the Text Boxes is Added to the Database
            using (SqlCommand update = new SqlCommand(Update, con))
            {
                update.Parameters.Add("@DateReturned", SqlDbType.DateTime).Value = DateTime.Now;

                con.Open();

                //Run the Query
                update.ExecuteNonQuery();

                con.Close();
            }

            return inResult;
        } //AddRent Ends

        public string AddMovie(string title, string year, string plot, string rate, string genre, string copies)
        {
            string addingResult = "Data Successfully Inserted into " + currTable;

            string NewEntry = "INSERT INTO Movies (Title, Year, Plot, Rating, Genre, Rental_Cost, Copies )" +
                              "VALUES(@Title, @Year, @Plot, @Rating, @Genre, 5, @Copies);";

            string stringError = MovieErrorCheck(addingResult, rate, title, year, copies, genre, plot);

            if (stringError == "NA") //All Text Boxes are appropriate
            {
                //This puts the Parameters into the Code so that the Data in the Text Boxes is Added to the Database
                using (SqlCommand newdata = new SqlCommand(NewEntry, con))
                {
                    newdata.Parameters.Add("@Title", SqlDbType.NVarChar).Value = title;
                    newdata.Parameters.Add("@Year", SqlDbType.NVarChar).Value = year;
                    newdata.Parameters.Add("@Plot", SqlDbType.NText).Value = plot;
                    newdata.Parameters.Add("@Rating", SqlDbType.NVarChar).Value = rate;
                    newdata.Parameters.Add("@Genre", SqlDbType.NVarChar).Value = genre;
                    newdata.Parameters.Add("@Copies", SqlDbType.NVarChar).Value = copies;

                    con.Open();

                    //Run the Query
                    newdata.ExecuteNonQuery();

                    con.Close();
                }
            }
            else
            {
                addingResult = stringError;
            }

            return addingResult;
        } //AddMovie Ends


        //Updating Database
        public string UpdateCust(string custID, string fName, string lName, string phone, string address)

        {
            string updateResult = "Data Successfully Updated in " + currTable;
            string stringError = "NA";
            string Update = "UPDATE Customer SET FirstName = @FirstName, LastName = @LastName, Phone = @Phone, Address = @Address WHERE CustID = " + custID + ";";

            string[] texts = { fName, lName, phone, address };

            for (int i = 0; i < texts.Length; i++)
            {

                if (texts[i].Length > 30)
                {

                    stringError = "The Text '" + texts[i] + "' is not appropriate as it is too long. Please shorten it.";
                    updateResult = stringError;
                    break;
                }
            }

            foreach (char c in phone) //foreach from jakobbotsch from stack overflow
            {
                if (c < '0' || c > '9')
                {
                    stringError = "The Text '" + phone + "' is not appropriate for a phone number. Numbers ONLY!";
                    updateResult = stringError;
                    break;
                }
            }

            if (updateResult != stringError) //All Text Boxes are appropriate
            {
                //This puts the Parameters into the Code so that the Data in the Text Boxes is Added to the Database
                using (SqlCommand update = new SqlCommand(Update, con))
                {
                    update.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = fName;
                    update.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lName;
                    update.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = phone;
                    update.Parameters.Add("@Address", SqlDbType.NVarChar).Value = address;

                    con.Open();

                    //Run the Query
                    update.ExecuteNonQuery();

                    con.Close();
                }
            }

            return updateResult;
        } //UpdateCust Ends

        public string UpdateRents(string rentsID, string custID, string movieID, string dateRent, string dateReturned)
        {
            string updateResult = "Data Successfully Updated in Rented Movies";

            string confirmEntryCust = "Select COUNT(CustID) FROM Customer WHERE CustID = " + custID + ";";
            int CustIDFK = 0;
            string confirmEntryMovie = "Select COUNT(MovieID) FROM Movies WHERE MovieID = " + movieID + ";";
            int MovieIDFK = 0;

            SqlCommand checkCust = new SqlCommand(confirmEntryCust, con);
            SqlCommand checkMovies = new SqlCommand(confirmEntryMovie, con);

            con.Open();

            //Run the Queries
            CustIDFK = Convert.ToInt32(checkCust.ExecuteScalar());
            MovieIDFK = Convert.ToInt32(checkMovies.ExecuteScalar());

            con.Close();

            if (CustIDFK > 0 && MovieIDFK > 0) //Checks that both Foreign Keys Exist
            {
                string dateCheckOut = "";
                string dateCheckIn = "";

                //Checks for Date in Correct Format for DateRented
                if (DateTime.TryParseExact(dateRent, "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime timeOut))
                {
                    dateCheckOut = ", DateRented = @DateRented";
                }
                else if (dateRent == "") //Setting to NULL
                {
                    dateCheckOut = ", DateRented = @DateRented";
                }

                //Checks for Date in Correct Format for Date Returned
                if (DateTime.TryParseExact(dateReturned, "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime timeIn))
                {
                    dateCheckIn = ", DateReturned = @DateReturned";
                }
                else if (dateReturned == "") //Setting to NULL
                {
                    dateCheckIn = ", DateReturned = @DateReturned";
                }

                string Update = "UPDATE RentedMovies SET CustIDFK = @CustIDFK, MovieIDFK = @MovieIDFK" + dateCheckOut + dateCheckIn +
                                " WHERE RMID = " + rentsID + ";";


                //This puts the Parameters into the Code so that the Data in the Text Boxes is Added to the Database
                using (SqlCommand update = new SqlCommand(Update, con))
                {
                    update.Parameters.Add("@CustIDFK", SqlDbType.NVarChar).Value = custID;
                    update.Parameters.Add("@MovieIDFK", SqlDbType.NVarChar).Value = movieID;

                    if (dateCheckOut != "" && dateRent != "") //Changing Date for Rented
                    {
                        update.Parameters.Add("@DateRented", SqlDbType.DateTime).Value = dateRent;
                    }
                    else if (dateRent == "") //Setting to NULL
                    {
                        update.Parameters.AddWithValue("@DateRented", DBNull.Value);
                    }

                    if (dateCheckIn != "" && dateReturned != "") //Changing Date for Returned
                    {
                        update.Parameters.Add("@DateReturned", SqlDbType.DateTime).Value = dateReturned;
                    }
                    else if (dateReturned == "") //Setting to NULL
                    {
                        update.Parameters.AddWithValue("@DateReturned", DBNull.Value);
                    }

                    con.Open();

                    //Run the Query
                    update.ExecuteNonQuery();

                    con.Close();
                }
            }
            else
            {
                if (CustIDFK <= 0 && MovieIDFK > 0)
                {
                    updateResult = "Customer ID & Movie ID is Invalid!";
                }
                else if (CustIDFK <= 0)
                {
                    updateResult = "Customer ID is Invalid!";
                }
                else
                {
                    updateResult = "Movie ID is Invalid!";
                }
            }

            return updateResult;
        }
        public string UpdateMovies(string movieID, string title, string year, string plot, string rate, string genre, string copies)
        {
            string updateResult = "Data Successfully Updated in " + currTable;

            string Update = "UPDATE Movies SET Title = @Title, Year = @Year, Plot = @Plot, Rating = @Rating, Genre = @Genre," +
                    " Rental_Cost = 5, Copies = @Copies WHERE MovieID = " + movieID + ";";

            string stringError = MovieErrorCheck(updateResult, rate, title, year, copies, genre, plot);

            if (stringError == "NA") //All Text Boxes are appropriate
            {
                //This puts the Parameters into the Code so that the Data in the Text Boxes is Added to the Database
                using (SqlCommand update = new SqlCommand(Update, con))
                {
                    update.Parameters.Add("@Title", SqlDbType.NVarChar).Value = title;
                    update.Parameters.Add("@Year", SqlDbType.NVarChar).Value = year;
                    update.Parameters.Add("@Plot", SqlDbType.NText).Value = plot;
                    update.Parameters.Add("@Rating", SqlDbType.NVarChar).Value = rate;
                    update.Parameters.Add("@Genre", SqlDbType.NVarChar).Value = genre;
                    update.Parameters.Add("@Copies", SqlDbType.NVarChar).Value = copies;

                    con.Open();

                    //Run the Query
                    update.ExecuteNonQuery();

                    con.Close();
                }
            }
            else
            {
                updateResult = stringError;
            }

            return updateResult;
        }


        //Deleting Data
        public string DeleteData(string thisTableID, string whichID, string custID, string movieID)
        {
            string delResult = "Data Successfully Deleted in " + currTable;

            if (whichID != "RM")
            {
                string condition = "";
                int activeRents = 1;

                if (custID != "")
                {
                    condition = "WHERE CustIDFK = @CustID";
                }
                else if (movieID != "")
                {
                    condition = "WHERE MovieIDFK = @MovieID";
                }

                if (condition != "")
                {
                    string confirmDel = "SELECT COUNT(RMID) FROM RentedMovies " + condition + ";";


                    SqlCommand checkDel = new SqlCommand(confirmDel, con);

                    if (custID != "")
                    {
                        checkDel.Parameters.AddWithValue("@ID", thisTableID);
                    }
                    else if (movieID != "")
                    {
                        checkDel.Parameters.Add("@MovieID", SqlDbType.NVarChar).Value = movieID;
                    }

                    con.Open();

                    //Run the Queries
                    activeRents = Convert.ToInt32(checkDel.ExecuteScalar());

                    con.Close();

                }

                if (activeRents == 0) //Checks that both Foreign Keys Exist
                {
                    string DeleteCommand = "DELETE " + currTable + " WHERE " + whichID + "ID = @ID";

                    SqlCommand delete = new SqlCommand(DeleteCommand, con);
                    delete.Parameters.AddWithValue("@ID", thisTableID);

                    con.Open();

                    //Run the Query
                    delete.ExecuteNonQuery();

                    con.Close();
                }
                else
                {
                    delResult = "Cannot DELETE! Must FIRST Delete Movie Rental Data with " + whichID + "ID = " + thisTableID + "!";
                }
            }
            else
            {
                string DeleteCommand = "DELETE " + currTable + " WHERE " + whichID + "ID = @ID";

                SqlCommand delete = new SqlCommand(DeleteCommand, con);
                delete.Parameters.AddWithValue("@ID", thisTableID);

                con.Open();

                //Run the Query
                delete.ExecuteNonQuery();

                con.Close();
            }
            return delResult;

        } //DeleteData Ends

        public DataTable GetBestBuyers()
        {
            DataTable bestCust = new DataTable();

            //Clears the datagrid
            bestCust.Clear();

            //Creating appropriate table
            bestCust.Columns.Add("First Name:");
            bestCust.Columns.Add("Last Name:");
            bestCust.Columns.Add("Currently Renting:");

            //Retreiving data from DB
            string query = @"SELECT * FROM BiggestRenter ORDER BY Expr1 DESC;";

            SqlCommand command = new SqlCommand(query, con);

            con.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                bestCust.Rows.Add(
                    reader["FirstName"],
                    reader["LastName"],
                    reader["Expr1"]
                    );
            }

            reader.Close();
            con.Close();

            return bestCust;
        } //GetBestBuyers End

        public DataTable GetBestMovie()
        {
            DataTable bestMovie = new DataTable();

            //Clears the datagrid
            bestMovie.Clear();

            //Creating appropriate table
            bestMovie.Columns.Add("Movie Title:");
            bestMovie.Columns.Add("No. of Movie Out:");

            //Retreiving data from DB
            string query = @"SELECT * FROM MostPopularMovie ORDER BY Expr1 DESC;";

            SqlCommand command = new SqlCommand(query, con);

            con.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                bestMovie.Rows.Add(
                    reader["Title"],
                    reader["Expr1"]
                    );
            }

            reader.Close();
            con.Close();

            return bestMovie;
        } //GetBestMovie

        public int priceRangeCheck()
        {
            //Counting data from DB
            string costQuery = @"SELECT Count(Rental_Cost) FROM Movies WHERE Rental_Cost != 2.00 AND Rental_Cost != 5.00;";

            SqlCommand SqlCheck2 = new SqlCommand(costQuery, con);

            con.Open();

            //Run the Query
            int totPriceOutBounds = Convert.ToInt32(SqlCheck2.ExecuteScalar());

            con.Close();

            return totPriceOutBounds;
        }
    }
}

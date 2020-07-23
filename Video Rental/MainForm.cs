using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Rental
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        DBLink Link = new DBLink();
        Logic Logic = new Logic();

        private void CustomersBtn_Click(object sender, EventArgs e) //Getting Customer Info
        {
            DbGridView.DataSource = Link.CallCustomers();
            Link.currTable = "Customer";

            Logic.MakeActive(CustomersBtn, RentsBtn, MoviesBtn,
                CreateBtn, UpdateBtn, DelBtn, RentOutBtn, RentInBtn,
                ViewAllRadioBtn, ViewOutRadioBtn, ViewInRadioBtn);
        }

        private void RentsBtn_Click(object sender, EventArgs e) //Getting Rented Movies Info
        {
            DbGridView.DataSource = Link.CallRents("");
            Link.currTable = "RentedMovies";

            Logic.MakeActive(RentsBtn, CustomersBtn, MoviesBtn,
                CreateBtn, UpdateBtn, DelBtn, RentOutBtn, RentInBtn,
                ViewAllRadioBtn, ViewOutRadioBtn, ViewInRadioBtn);
        }

        private void MoviesBtn_Click(object sender, EventArgs e) //Getting Movies Info
        {
            DbGridView.DataSource = Link.CallMovies();
            Link.currTable = "Movies";

            Logic.MakeActive(MoviesBtn, RentsBtn, CustomersBtn,
                CreateBtn, UpdateBtn, DelBtn, RentOutBtn, RentInBtn,
                ViewAllRadioBtn, ViewOutRadioBtn, ViewInRadioBtn);
        }

        private void DbGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) //Obtaining Clicked Cells Information
        {
            TextBox[] AllTxtBoxs = { CustIDTxtBox, FirstNameTxtBox, LastNameTxtBox, PhoneTxtBox, AddressTxtBox,
                                     RentsIDTxtBox, DateRentTxtBox, DateReturnedTxtBox,
                                     MovieIDTxtBox, TitleTxtBox, ReleasedTxtBox, PlotTxtBox, RateTxtBox, GenreTxtBox, CostTxtBox, CopiesTxtBox};

            //Clears Prev Info for New Data
            for (int i = 0; i < AllTxtBoxs.Length; i++)
            {
                AllTxtBoxs[i].Text = "";
            }

            try
            {
                //Retreives Data from the text boxes
                string newvalue = DbGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                this.Text = Link.currTable + " Row : " + e.RowIndex.ToString() + " Col : " +
                e.ColumnIndex.ToString() + " Value = " + newvalue;

                //Pass Data to Text Boxes
                if (Link.currTable.Remove(1, Link.currTable.Length - 1) == "C") //If Current Tab is Customer
                {
                    CustIDTxtBox.Text = DbGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    FirstNameTxtBox.Text = DbGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    LastNameTxtBox.Text = DbGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    PhoneTxtBox.Text = DbGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    AddressTxtBox.Text = DbGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
                else if (Link.currTable.Remove(1, Link.currTable.Length - 1) == "R") //If Current Tab is Rented Movies
                {
                    RentsIDTxtBox.Text = DbGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    CustIDTxtBox.Text = DbGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    MovieIDTxtBox.Text = DbGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    DateRentTxtBox.Text = DbGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    DateReturnedTxtBox.Text = DbGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                    //Collecting Information about Customer & Movie Aswell --- Using Customer ID and Movie ID
                    Link.GetRentInfo(CustIDTxtBox.Text, MovieIDTxtBox.Text,
                                     out string fName, out string lName, out string phone, out string home,
                                     out string title, out string year, out string plot, out string rating, out string genre, out string cost, out string copies);

                    //Adding Customer Info
                    FirstNameTxtBox.Text = fName;
                    LastNameTxtBox.Text = lName;
                    PhoneTxtBox.Text = phone;
                    AddressTxtBox.Text = home;

                    //Adding Movie Info
                    TitleTxtBox.Text = title;
                    ReleasedTxtBox.Text = year;
                    PlotTxtBox.Text = plot;
                    RateTxtBox.Text = rating;
                    GenreTxtBox.Text = genre;
                    CostTxtBox.Text = cost;
                    CopiesTxtBox.Text = copies;
                }
                else if (Link.currTable.Remove(1, Link.currTable.Length - 1) == "M") //If Current Tab is Movies
                {
                    MovieIDTxtBox.Text = DbGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    TitleTxtBox.Text = DbGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    ReleasedTxtBox.Text = DbGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    PlotTxtBox.Text = DbGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    RateTxtBox.Text = DbGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                    GenreTxtBox.Text = DbGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                    CostTxtBox.Text = DbGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                    CopiesTxtBox.Text = DbGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                }

            }
            catch
            {
            }
        } //DbGridView  Ends

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (Link.currTable.Remove(1, Link.currTable.Length - 1) == "C") //If Current Tab is Customer
            {
                MessageBox.Show(Link.AddCustomer(CustIDTxtBox.Text, FirstNameTxtBox.Text, LastNameTxtBox.Text, PhoneTxtBox.Text, AddressTxtBox.Text));

                DbGridView.DataSource = Link.CallCustomers();
            }
            else if (Link.currTable.Remove(1, Link.currTable.Length - 1) == "M") //If Current Tab is Rented Movies
            {
                MessageBox.Show(Link.AddMovie(TitleTxtBox.Text, ReleasedTxtBox.Text, PlotTxtBox.Text, RateTxtBox.Text, GenreTxtBox.Text, CopiesTxtBox.Text));

                DbGridView.DataSource = Link.CallMovies();
            }
            
        } //Create Btn Ends

        private void RentOutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Link.AddRent(CustIDTxtBox.Text, MovieIDTxtBox.Text));

            DbGridView.DataSource = Link.CallRents("WHERE DateReturned IS NULL ");
            ViewOutRadioBtn.Checked = true;
        }

        private void RentInBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Link.RentIn(RentsIDTxtBox.Text));

            DbGridView.DataSource = Link.CallRents("WHERE DateReturned IS NOT NULL ");
            ViewInRadioBtn.Checked = true;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (Link.currTable.Remove(1, Link.currTable.Length - 1) == "C") //If Current Tab is Customer
            {
                MessageBox.Show(Link.UpdateCust(CustIDTxtBox.Text, FirstNameTxtBox.Text, LastNameTxtBox.Text, PhoneTxtBox.Text, AddressTxtBox.Text));

                DbGridView.DataSource = Link.CallCustomers();
            }
            else if (Link.currTable.Remove(1, Link.currTable.Length - 1) == "R") //If Current Tab is Rented Movies
            {
                MessageBox.Show(Link.UpdateRents(RentsIDTxtBox.Text, CustIDTxtBox.Text, MovieIDTxtBox.Text, DateRentTxtBox.Text, DateReturnedTxtBox.Text));

                DbGridView.DataSource = Link.CallRents("");
                ViewAllRadioBtn.Checked = true;
            }
            else if (Link.currTable.Remove(1, Link.currTable.Length - 1) == "M") //If Current Tab is Movies
            {
                MessageBox.Show(Link.UpdateMovies(MovieIDTxtBox.Text, TitleTxtBox.Text, ReleasedTxtBox.Text, PlotTxtBox.Text, RateTxtBox.Text,
                                                  GenreTxtBox.Text, CopiesTxtBox.Text));

                DbGridView.DataSource = Link.CallMovies();
            }
        } //Update Btn Ends

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (Link.currTable.Remove(1, Link.currTable.Length - 1) == "C") //If Current Tab is Customer
            {
                MessageBox.Show(Link.DeleteData(CustIDTxtBox.Text, "Cust"));

                DbGridView.DataSource = Link.CallCustomers();
            }
            else if (Link.currTable.Remove(1, Link.currTable.Length - 1) == "R") //If Current Tab is Rented Movies
            {
                MessageBox.Show(Link.DeleteData(RentsIDTxtBox.Text, "RM"));

                DbGridView.DataSource = Link.CallRents("");
                ViewAllRadioBtn.Checked = true;
            }
            else if (Link.currTable.Remove(1, Link.currTable.Length - 1) == "M") //If Current Tab is Movies
            {
                MessageBox.Show(Link.DeleteData(MovieIDTxtBox.Text, "Movie"));

                DbGridView.DataSource = Link.CallMovies();
            }
        } //Delete Btn Ends

        private void ViewAllRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            DbGridView.DataSource = Link.CallRents("");
        }

        private void ViewOutRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            DbGridView.DataSource = Link.CallRents("WHERE DateReturned IS NULL ");
        }

        private void ViewInRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            DbGridView.DataSource = Link.CallRents("WHERE DateReturned IS NOT NULL ");
        }
    }
}
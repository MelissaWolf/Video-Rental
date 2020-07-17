using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void CustomersBtn_Click(object sender, EventArgs e) //Getting Customer Info
        {
            DbGridView.DataSource = Link.CallCustomers();
            Link.currTable = "Customers";
        }

        private void RentsBtn_Click(object sender, EventArgs e) //Getting Rented Movies Info
        {
            DbGridView.DataSource = Link.CallRents();
            Link.currTable = "Rented Movies";
        }

        private void MoviesBtn_Click(object sender, EventArgs e) //Getting Movies Info
        {
            DbGridView.DataSource = Link.CallMovies();
            Link.currTable = "Movies";
        }

        private void DbGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) //Obtaining Clicked Cells Information
        {
            TextBox[] AllTxtBoxs = { CustIDTxtBox, FirstNameTxtBox, LastNameTxtBox, PhoneTxtBox, AddressTxtBox,
                                     RentsIDTxtBox, DateRentTxtBox, DateReturnedTxtBox, MovieIDTxtBox, TitleTxtBox,
                                     ReleasedTxtBox, PlotTxtBox, RateTxtBox, GenreTxtBox, CostTxtBox, CopiesTxtBox};

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
        }

        
    }
}

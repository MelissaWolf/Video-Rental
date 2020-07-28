using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Rental
{
    public class Logic
    {
        public void MakeActive(Button newActive, Button notActive1, Button notActive2, Button notActive3,
                               Button CreateBtn, Button UpdateBtn, Button DelBtn, Button RentOutBtn, Button RentInBtn,
                               RadioButton ViewAllRadioBtn, RadioButton ViewOutRadioBtn, RadioButton ViewInRadioBtn,
                               DataGridView DbGridView, DataGridView BestBuyerGridView, DataGridView BestMovieGridView)
        {
            //Making Button Active
            newActive.BackColor = Color.Teal;
            newActive.ForeColor = Color.White;

            //Setting Button Inactive
            notActive1.BackColor = Color.DarkGray;
            notActive1.ForeColor = Color.Black;

            notActive2.BackColor = Color.DarkGray;
            notActive2.ForeColor = Color.Black;

            notActive3.BackColor = Color.DarkGray;
            notActive3.ForeColor = Color.Black;

            if (newActive.Name == "RentsBtn") //If Rent Btn was Clicked
            {
                DbGridView.Visible = true;

                CreateBtn.Visible = false;
                UpdateBtn.Visible = true;
                DelBtn.Visible = true;

                RentOutBtn.Visible = true;
                RentInBtn.Visible = true;

                ViewAllRadioBtn.Visible = true;
                ViewAllRadioBtn.Checked = true; //Checked because ALL data is automatically shown
                ViewOutRadioBtn.Visible = true;
                ViewInRadioBtn.Visible = true;

                BestBuyerGridView.Visible = false;
                BestMovieGridView.Visible = false;
            }
            else if(newActive.Name == "StatsBtn") //If Stats Btn was Clicked
            {
                DbGridView.Visible = false;

                CreateBtn.Visible = false;
                UpdateBtn.Visible = false;
                DelBtn.Visible = false;

                RentOutBtn.Visible = false;
                RentInBtn.Visible = false;

                ViewAllRadioBtn.Visible = false;
                ViewOutRadioBtn.Visible = false;
                ViewInRadioBtn.Visible = false;

                BestBuyerGridView.Visible = true;
                BestMovieGridView.Visible = true;
            }
            else
            {
                DbGridView.Visible = true;

                CreateBtn.Visible = true;
                UpdateBtn.Visible = true;
                DelBtn.Visible = true;

                RentOutBtn.Visible = false;
                RentInBtn.Visible = false;

                ViewAllRadioBtn.Visible = false;
                ViewOutRadioBtn.Visible = false;
                ViewInRadioBtn.Visible = false;

                BestBuyerGridView.Visible = false;
                BestMovieGridView.Visible = false;
            }
        }

    }
}

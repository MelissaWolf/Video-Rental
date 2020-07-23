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
        public void MakeActive(Button newActive, Button notActive1, Button notActive2,
                               Button CreateBtn, Button UpdateBtn, Button DelBtn, Button RentOutBtn, Button RentInBtn,
                               RadioButton ViewAllRadioBtn, RadioButton ViewOutRadioBtn, RadioButton ViewInRadioBtn)
        {
            //Making Button Active
            newActive.BackColor = Color.Teal;
            newActive.ForeColor = Color.White;

            //Setting Button Inactive
            notActive1.BackColor = Color.DarkGray;
            notActive1.ForeColor = Color.Black;

            notActive2.BackColor = Color.DarkGray;
            notActive2.ForeColor = Color.Black;

            if (newActive.Name == "RentsBtn") //If Rent Btn was Clicked
            {
                CreateBtn.Visible = false;
                UpdateBtn.Visible = true;
                DelBtn.Visible = true;

                RentOutBtn.Visible = true;
                RentInBtn.Visible = true;

                ViewAllRadioBtn.Visible = true;
                ViewAllRadioBtn.Checked = true; //Checked because ALL data is automatically shown
                ViewOutRadioBtn.Visible = true;
                ViewInRadioBtn.Visible = true;
            }
            else
            {
                CreateBtn.Visible = true;
                UpdateBtn.Visible = true;
                DelBtn.Visible = true;

                RentOutBtn.Visible = false;
                RentInBtn.Visible = false;

                ViewAllRadioBtn.Visible = false;
                ViewOutRadioBtn.Visible = false;
                ViewInRadioBtn.Visible = false;
            }
        }

    }
}

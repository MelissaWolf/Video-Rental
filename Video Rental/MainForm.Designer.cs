namespace Video_Rental
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DbGridView = new System.Windows.Forms.DataGridView();
            this.CustomersBtn = new System.Windows.Forms.Button();
            this.RentsBtn = new System.Windows.Forms.Button();
            this.MoviesBtn = new System.Windows.Forms.Button();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.CustIDTxtBox = new System.Windows.Forms.TextBox();
            this.LastNameTxtBox = new System.Windows.Forms.TextBox();
            this.IDLbl = new System.Windows.Forms.Label();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.RentsIDTxtBox = new System.Windows.Forms.TextBox();
            this.MovieIDTxtBox = new System.Windows.Forms.TextBox();
            this.RentIDLbl = new System.Windows.Forms.Label();
            this.MovieIDLbl = new System.Windows.Forms.Label();
            this.PhoneTxtBox = new System.Windows.Forms.TextBox();
            this.AddressTxtBox = new System.Windows.Forms.TextBox();
            this.DateRentTxtBox = new System.Windows.Forms.TextBox();
            this.DateReturnedTxtBox = new System.Windows.Forms.TextBox();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.DateRentedLbl = new System.Windows.Forms.Label();
            this.DateReturnedLbl = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.TitleTxtBox = new System.Windows.Forms.TextBox();
            this.ReleasedTxtBox = new System.Windows.Forms.TextBox();
            this.YearRealeasedLbl = new System.Windows.Forms.Label();
            this.PlotTxtBox = new System.Windows.Forms.TextBox();
            this.PlotLbl = new System.Windows.Forms.Label();
            this.RateTxtBox = new System.Windows.Forms.TextBox();
            this.RatingLbl = new System.Windows.Forms.Label();
            this.CostTxtBox = new System.Windows.Forms.TextBox();
            this.GenreTxtBox = new System.Windows.Forms.TextBox();
            this.CopiesTxtBox = new System.Windows.Forms.TextBox();
            this.GenreLbl = new System.Windows.Forms.Label();
            this.CostLbl = new System.Windows.Forms.Label();
            this.CopiesLbl = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.RentOutBtn = new System.Windows.Forms.Button();
            this.RentInBtn = new System.Windows.Forms.Button();
            this.ViewAllRadioBtn = new System.Windows.Forms.RadioButton();
            this.ViewOutRadioBtn = new System.Windows.Forms.RadioButton();
            this.ViewInRadioBtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DbGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DbGridView
            // 
            this.DbGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DbGridView.Location = new System.Drawing.Point(12, 45);
            this.DbGridView.Name = "DbGridView";
            this.DbGridView.RowHeadersWidth = 51;
            this.DbGridView.RowTemplate.Height = 24;
            this.DbGridView.Size = new System.Drawing.Size(1184, 361);
            this.DbGridView.TabIndex = 0;
            this.DbGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DbGridView_CellContentClick);
            // 
            // CustomersBtn
            // 
            this.CustomersBtn.BackColor = System.Drawing.Color.DarkGray;
            this.CustomersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersBtn.ForeColor = System.Drawing.Color.Black;
            this.CustomersBtn.Location = new System.Drawing.Point(12, 4);
            this.CustomersBtn.Name = "CustomersBtn";
            this.CustomersBtn.Size = new System.Drawing.Size(155, 35);
            this.CustomersBtn.TabIndex = 6;
            this.CustomersBtn.Text = "Customers";
            this.CustomersBtn.UseVisualStyleBackColor = false;
            this.CustomersBtn.Click += new System.EventHandler(this.CustomersBtn_Click);
            // 
            // RentsBtn
            // 
            this.RentsBtn.BackColor = System.Drawing.Color.DarkGray;
            this.RentsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.RentsBtn.ForeColor = System.Drawing.Color.Black;
            this.RentsBtn.Location = new System.Drawing.Point(173, 4);
            this.RentsBtn.Name = "RentsBtn";
            this.RentsBtn.Size = new System.Drawing.Size(155, 35);
            this.RentsBtn.TabIndex = 7;
            this.RentsBtn.Text = "Rented Movies";
            this.RentsBtn.UseVisualStyleBackColor = false;
            this.RentsBtn.Click += new System.EventHandler(this.RentsBtn_Click);
            // 
            // MoviesBtn
            // 
            this.MoviesBtn.BackColor = System.Drawing.Color.DarkGray;
            this.MoviesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.MoviesBtn.ForeColor = System.Drawing.Color.Black;
            this.MoviesBtn.Location = new System.Drawing.Point(334, 4);
            this.MoviesBtn.Name = "MoviesBtn";
            this.MoviesBtn.Size = new System.Drawing.Size(155, 35);
            this.MoviesBtn.TabIndex = 8;
            this.MoviesBtn.Text = "Movies";
            this.MoviesBtn.UseVisualStyleBackColor = false;
            this.MoviesBtn.Click += new System.EventHandler(this.MoviesBtn_Click);
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.Location = new System.Drawing.Point(131, 437);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(227, 22);
            this.FirstNameTxtBox.TabIndex = 12;
            // 
            // CustIDTxtBox
            // 
            this.CustIDTxtBox.Location = new System.Drawing.Point(12, 437);
            this.CustIDTxtBox.Name = "CustIDTxtBox";
            this.CustIDTxtBox.Size = new System.Drawing.Size(113, 22);
            this.CustIDTxtBox.TabIndex = 13;
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.Location = new System.Drawing.Point(364, 437);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(227, 22);
            this.LastNameTxtBox.TabIndex = 14;
            // 
            // IDLbl
            // 
            this.IDLbl.AutoSize = true;
            this.IDLbl.Location = new System.Drawing.Point(13, 417);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(89, 17);
            this.IDLbl.TabIndex = 19;
            this.IDLbl.Text = "Customer ID:";
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Location = new System.Drawing.Point(128, 417);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(80, 17);
            this.FirstNameLbl.TabIndex = 20;
            this.FirstNameLbl.Text = "First Name:";
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Location = new System.Drawing.Point(361, 417);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(80, 17);
            this.LastNameLbl.TabIndex = 21;
            this.LastNameLbl.Text = "Last Name:";
            // 
            // RentsIDTxtBox
            // 
            this.RentsIDTxtBox.Location = new System.Drawing.Point(12, 522);
            this.RentsIDTxtBox.Name = "RentsIDTxtBox";
            this.RentsIDTxtBox.Size = new System.Drawing.Size(113, 22);
            this.RentsIDTxtBox.TabIndex = 24;
            // 
            // MovieIDTxtBox
            // 
            this.MovieIDTxtBox.Location = new System.Drawing.Point(12, 607);
            this.MovieIDTxtBox.Name = "MovieIDTxtBox";
            this.MovieIDTxtBox.Size = new System.Drawing.Size(113, 22);
            this.MovieIDTxtBox.TabIndex = 26;
            // 
            // RentIDLbl
            // 
            this.RentIDLbl.AutoSize = true;
            this.RentIDLbl.Location = new System.Drawing.Point(9, 502);
            this.RentIDLbl.Name = "RentIDLbl";
            this.RentIDLbl.Size = new System.Drawing.Size(116, 17);
            this.RentIDLbl.TabIndex = 27;
            this.RentIDLbl.Text = "Rented Movie ID:";
            // 
            // MovieIDLbl
            // 
            this.MovieIDLbl.AutoSize = true;
            this.MovieIDLbl.Location = new System.Drawing.Point(9, 587);
            this.MovieIDLbl.Name = "MovieIDLbl";
            this.MovieIDLbl.Size = new System.Drawing.Size(66, 17);
            this.MovieIDLbl.TabIndex = 28;
            this.MovieIDLbl.Text = "Movie ID:";
            // 
            // PhoneTxtBox
            // 
            this.PhoneTxtBox.Location = new System.Drawing.Point(597, 437);
            this.PhoneTxtBox.Name = "PhoneTxtBox";
            this.PhoneTxtBox.Size = new System.Drawing.Size(227, 22);
            this.PhoneTxtBox.TabIndex = 29;
            // 
            // AddressTxtBox
            // 
            this.AddressTxtBox.Location = new System.Drawing.Point(830, 437);
            this.AddressTxtBox.Name = "AddressTxtBox";
            this.AddressTxtBox.Size = new System.Drawing.Size(366, 22);
            this.AddressTxtBox.TabIndex = 30;
            // 
            // DateRentTxtBox
            // 
            this.DateRentTxtBox.Location = new System.Drawing.Point(131, 522);
            this.DateRentTxtBox.Name = "DateRentTxtBox";
            this.DateRentTxtBox.Size = new System.Drawing.Size(227, 22);
            this.DateRentTxtBox.TabIndex = 31;
            // 
            // DateReturnedTxtBox
            // 
            this.DateReturnedTxtBox.Location = new System.Drawing.Point(364, 522);
            this.DateReturnedTxtBox.Name = "DateReturnedTxtBox";
            this.DateReturnedTxtBox.Size = new System.Drawing.Size(227, 22);
            this.DateReturnedTxtBox.TabIndex = 32;
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Location = new System.Drawing.Point(594, 417);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(53, 17);
            this.PhoneLbl.TabIndex = 33;
            this.PhoneLbl.Text = "Phone:";
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Location = new System.Drawing.Point(827, 417);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(64, 17);
            this.AddressLbl.TabIndex = 34;
            this.AddressLbl.Text = "Address:";
            // 
            // DateRentedLbl
            // 
            this.DateRentedLbl.AutoSize = true;
            this.DateRentedLbl.Location = new System.Drawing.Point(131, 502);
            this.DateRentedLbl.Name = "DateRentedLbl";
            this.DateRentedLbl.Size = new System.Drawing.Size(92, 17);
            this.DateRentedLbl.TabIndex = 35;
            this.DateRentedLbl.Text = "Date Rented:";
            // 
            // DateReturnedLbl
            // 
            this.DateReturnedLbl.AutoSize = true;
            this.DateReturnedLbl.Location = new System.Drawing.Point(361, 502);
            this.DateReturnedLbl.Name = "DateReturnedLbl";
            this.DateReturnedLbl.Size = new System.Drawing.Size(105, 17);
            this.DateReturnedLbl.TabIndex = 36;
            this.DateReturnedLbl.Text = "Date Returned:";
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Location = new System.Drawing.Point(128, 587);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(39, 17);
            this.TitleLbl.TabIndex = 38;
            this.TitleLbl.Text = "Title:";
            // 
            // TitleTxtBox
            // 
            this.TitleTxtBox.Location = new System.Drawing.Point(131, 607);
            this.TitleTxtBox.Name = "TitleTxtBox";
            this.TitleTxtBox.Size = new System.Drawing.Size(227, 22);
            this.TitleTxtBox.TabIndex = 37;
            // 
            // ReleasedTxtBox
            // 
            this.ReleasedTxtBox.Location = new System.Drawing.Point(364, 607);
            this.ReleasedTxtBox.Name = "ReleasedTxtBox";
            this.ReleasedTxtBox.Size = new System.Drawing.Size(125, 22);
            this.ReleasedTxtBox.TabIndex = 39;
            // 
            // YearRealeasedLbl
            // 
            this.YearRealeasedLbl.AutoSize = true;
            this.YearRealeasedLbl.Location = new System.Drawing.Point(361, 587);
            this.YearRealeasedLbl.Name = "YearRealeasedLbl";
            this.YearRealeasedLbl.Size = new System.Drawing.Size(106, 17);
            this.YearRealeasedLbl.TabIndex = 40;
            this.YearRealeasedLbl.Text = "Year Released:";
            // 
            // PlotTxtBox
            // 
            this.PlotTxtBox.Location = new System.Drawing.Point(495, 607);
            this.PlotTxtBox.Multiline = true;
            this.PlotTxtBox.Name = "PlotTxtBox";
            this.PlotTxtBox.Size = new System.Drawing.Size(570, 93);
            this.PlotTxtBox.TabIndex = 41;
            // 
            // PlotLbl
            // 
            this.PlotLbl.AutoSize = true;
            this.PlotLbl.Location = new System.Drawing.Point(492, 587);
            this.PlotLbl.Name = "PlotLbl";
            this.PlotLbl.Size = new System.Drawing.Size(36, 17);
            this.PlotLbl.TabIndex = 42;
            this.PlotLbl.Text = "Plot:";
            // 
            // RateTxtBox
            // 
            this.RateTxtBox.Location = new System.Drawing.Point(1071, 607);
            this.RateTxtBox.Name = "RateTxtBox";
            this.RateTxtBox.Size = new System.Drawing.Size(125, 22);
            this.RateTxtBox.TabIndex = 43;
            // 
            // RatingLbl
            // 
            this.RatingLbl.AutoSize = true;
            this.RatingLbl.Location = new System.Drawing.Point(1068, 587);
            this.RatingLbl.Name = "RatingLbl";
            this.RatingLbl.Size = new System.Drawing.Size(53, 17);
            this.RatingLbl.TabIndex = 44;
            this.RatingLbl.Text = "Rating:";
            // 
            // CostTxtBox
            // 
            this.CostTxtBox.Location = new System.Drawing.Point(364, 678);
            this.CostTxtBox.Name = "CostTxtBox";
            this.CostTxtBox.Size = new System.Drawing.Size(125, 22);
            this.CostTxtBox.TabIndex = 46;
            // 
            // GenreTxtBox
            // 
            this.GenreTxtBox.Location = new System.Drawing.Point(131, 678);
            this.GenreTxtBox.Name = "GenreTxtBox";
            this.GenreTxtBox.Size = new System.Drawing.Size(227, 22);
            this.GenreTxtBox.TabIndex = 47;
            // 
            // CopiesTxtBox
            // 
            this.CopiesTxtBox.Location = new System.Drawing.Point(1071, 678);
            this.CopiesTxtBox.Name = "CopiesTxtBox";
            this.CopiesTxtBox.Size = new System.Drawing.Size(125, 22);
            this.CopiesTxtBox.TabIndex = 48;
            // 
            // GenreLbl
            // 
            this.GenreLbl.AutoSize = true;
            this.GenreLbl.Location = new System.Drawing.Point(131, 658);
            this.GenreLbl.Name = "GenreLbl";
            this.GenreLbl.Size = new System.Drawing.Size(52, 17);
            this.GenreLbl.TabIndex = 49;
            this.GenreLbl.Text = "Genre:";
            // 
            // CostLbl
            // 
            this.CostLbl.AutoSize = true;
            this.CostLbl.Location = new System.Drawing.Point(361, 658);
            this.CostLbl.Name = "CostLbl";
            this.CostLbl.Size = new System.Drawing.Size(85, 17);
            this.CostLbl.TabIndex = 50;
            this.CostLbl.Text = "Rental Cost:";
            // 
            // CopiesLbl
            // 
            this.CopiesLbl.AutoSize = true;
            this.CopiesLbl.Location = new System.Drawing.Point(1068, 658);
            this.CopiesLbl.Name = "CopiesLbl";
            this.CopiesLbl.Size = new System.Drawing.Size(55, 17);
            this.CopiesLbl.TabIndex = 51;
            this.CopiesLbl.Text = "Copies:";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBtn.Location = new System.Drawing.Point(1202, 45);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(153, 97);
            this.CreateBtn.TabIndex = 52;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Visible = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(1202, 171);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(153, 97);
            this.UpdateBtn.TabIndex = 53;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Visible = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.Firebrick;
            this.DelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBtn.Location = new System.Drawing.Point(1202, 309);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(153, 97);
            this.DelBtn.TabIndex = 54;
            this.DelBtn.Text = "DELETE";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Visible = false;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // RentOutBtn
            // 
            this.RentOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentOutBtn.Location = new System.Drawing.Point(830, 482);
            this.RentOutBtn.Name = "RentOutBtn";
            this.RentOutBtn.Size = new System.Drawing.Size(153, 97);
            this.RentOutBtn.TabIndex = 55;
            this.RentOutBtn.Text = "Movie Out";
            this.RentOutBtn.UseVisualStyleBackColor = true;
            this.RentOutBtn.Visible = false;
            this.RentOutBtn.Click += new System.EventHandler(this.RentOutBtn_Click);
            // 
            // RentInBtn
            // 
            this.RentInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentInBtn.Location = new System.Drawing.Point(1043, 482);
            this.RentInBtn.Name = "RentInBtn";
            this.RentInBtn.Size = new System.Drawing.Size(153, 97);
            this.RentInBtn.TabIndex = 56;
            this.RentInBtn.Text = "Movie In";
            this.RentInBtn.UseVisualStyleBackColor = true;
            this.RentInBtn.Visible = false;
            this.RentInBtn.Click += new System.EventHandler(this.RentInBtn_Click);
            // 
            // ViewAllRadioBtn
            // 
            this.ViewAllRadioBtn.AutoSize = true;
            this.ViewAllRadioBtn.Location = new System.Drawing.Point(653, 502);
            this.ViewAllRadioBtn.Name = "ViewAllRadioBtn";
            this.ViewAllRadioBtn.Size = new System.Drawing.Size(44, 21);
            this.ViewAllRadioBtn.TabIndex = 57;
            this.ViewAllRadioBtn.Text = "All";
            this.ViewAllRadioBtn.UseVisualStyleBackColor = true;
            this.ViewAllRadioBtn.Visible = false;
            this.ViewAllRadioBtn.CheckedChanged += new System.EventHandler(this.ViewAllRadioBtn_CheckedChanged);
            // 
            // ViewOutRadioBtn
            // 
            this.ViewOutRadioBtn.AutoSize = true;
            this.ViewOutRadioBtn.Location = new System.Drawing.Point(653, 529);
            this.ViewOutRadioBtn.Name = "ViewOutRadioBtn";
            this.ViewOutRadioBtn.Size = new System.Drawing.Size(100, 21);
            this.ViewOutRadioBtn.TabIndex = 58;
            this.ViewOutRadioBtn.TabStop = true;
            this.ViewOutRadioBtn.Text = "Movies Out";
            this.ViewOutRadioBtn.UseVisualStyleBackColor = true;
            this.ViewOutRadioBtn.Visible = false;
            this.ViewOutRadioBtn.CheckedChanged += new System.EventHandler(this.ViewOutRadioBtn_CheckedChanged);
            // 
            // ViewInRadioBtn
            // 
            this.ViewInRadioBtn.AutoSize = true;
            this.ViewInRadioBtn.Location = new System.Drawing.Point(653, 556);
            this.ViewInRadioBtn.Name = "ViewInRadioBtn";
            this.ViewInRadioBtn.Size = new System.Drawing.Size(136, 21);
            this.ViewInRadioBtn.TabIndex = 60;
            this.ViewInRadioBtn.TabStop = true;
            this.ViewInRadioBtn.Text = "Movies Returned";
            this.ViewInRadioBtn.UseVisualStyleBackColor = true;
            this.ViewInRadioBtn.Visible = false;
            this.ViewInRadioBtn.CheckedChanged += new System.EventHandler(this.ViewInRadioBtn_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1367, 712);
            this.Controls.Add(this.ViewInRadioBtn);
            this.Controls.Add(this.ViewOutRadioBtn);
            this.Controls.Add(this.ViewAllRadioBtn);
            this.Controls.Add(this.RentInBtn);
            this.Controls.Add(this.RentOutBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.CopiesLbl);
            this.Controls.Add(this.CostLbl);
            this.Controls.Add(this.GenreLbl);
            this.Controls.Add(this.CopiesTxtBox);
            this.Controls.Add(this.GenreTxtBox);
            this.Controls.Add(this.CostTxtBox);
            this.Controls.Add(this.RatingLbl);
            this.Controls.Add(this.RateTxtBox);
            this.Controls.Add(this.PlotLbl);
            this.Controls.Add(this.PlotTxtBox);
            this.Controls.Add(this.YearRealeasedLbl);
            this.Controls.Add(this.ReleasedTxtBox);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.TitleTxtBox);
            this.Controls.Add(this.DateReturnedLbl);
            this.Controls.Add(this.DateRentedLbl);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.PhoneLbl);
            this.Controls.Add(this.DateReturnedTxtBox);
            this.Controls.Add(this.DateRentTxtBox);
            this.Controls.Add(this.AddressTxtBox);
            this.Controls.Add(this.PhoneTxtBox);
            this.Controls.Add(this.MovieIDLbl);
            this.Controls.Add(this.RentIDLbl);
            this.Controls.Add(this.MovieIDTxtBox);
            this.Controls.Add(this.RentsIDTxtBox);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.IDLbl);
            this.Controls.Add(this.LastNameTxtBox);
            this.Controls.Add(this.CustIDTxtBox);
            this.Controls.Add(this.FirstNameTxtBox);
            this.Controls.Add(this.MoviesBtn);
            this.Controls.Add(this.RentsBtn);
            this.Controls.Add(this.CustomersBtn);
            this.Controls.Add(this.DbGridView);
            this.Name = "MainForm";
            this.Text = "Video Rental";
            ((System.ComponentModel.ISupportInitialize)(this.DbGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DbGridView;
        private System.Windows.Forms.Button CustomersBtn;
        private System.Windows.Forms.Button RentsBtn;
        private System.Windows.Forms.Button MoviesBtn;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.TextBox CustIDTxtBox;
        private System.Windows.Forms.TextBox LastNameTxtBox;
        private System.Windows.Forms.Label IDLbl;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.TextBox RentsIDTxtBox;
        private System.Windows.Forms.TextBox MovieIDTxtBox;
        private System.Windows.Forms.Label RentIDLbl;
        private System.Windows.Forms.Label MovieIDLbl;
        private System.Windows.Forms.TextBox PhoneTxtBox;
        private System.Windows.Forms.TextBox AddressTxtBox;
        private System.Windows.Forms.TextBox DateRentTxtBox;
        private System.Windows.Forms.TextBox DateReturnedTxtBox;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.Label DateRentedLbl;
        private System.Windows.Forms.Label DateReturnedLbl;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.TextBox TitleTxtBox;
        private System.Windows.Forms.TextBox ReleasedTxtBox;
        private System.Windows.Forms.Label YearRealeasedLbl;
        private System.Windows.Forms.TextBox PlotTxtBox;
        private System.Windows.Forms.Label PlotLbl;
        private System.Windows.Forms.TextBox RateTxtBox;
        private System.Windows.Forms.Label RatingLbl;
        private System.Windows.Forms.TextBox CostTxtBox;
        private System.Windows.Forms.TextBox GenreTxtBox;
        private System.Windows.Forms.TextBox CopiesTxtBox;
        private System.Windows.Forms.Label GenreLbl;
        private System.Windows.Forms.Label CostLbl;
        private System.Windows.Forms.Label CopiesLbl;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button RentOutBtn;
        private System.Windows.Forms.Button RentInBtn;
        private System.Windows.Forms.RadioButton ViewAllRadioBtn;
        private System.Windows.Forms.RadioButton ViewOutRadioBtn;
        private System.Windows.Forms.RadioButton ViewInRadioBtn;
    }
}


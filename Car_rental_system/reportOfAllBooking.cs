﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_rental_system
{
    public partial class reportOfAllBooking : Form
    {
        public reportOfAllBooking()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void reportOfAllBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetForCars.TypesOfCars' table. You can move, or remove it, as needed.
            this.TypesOfCarsTableAdapter.Fill(this.DataSetForCars.TypesOfCars);
            // TODO: This line of code loads data into the 'DataSetForBooking.Booking' table. You can move, or remove it, as needed.
            this.BookingTableAdapter.Fill(this.DataSetForBooking.Booking);

            this.reportViewer1.RefreshReport();
        }

    }
}

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
    public partial class reportOfAllCustomers : Form
    {
        public reportOfAllCustomers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void reportOfAllCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetForCustomer.Users' table. You can move, or remove it, as needed.
            this.UsersTableAdapter.Fill(this.DataSetForCustomer.Users);

            this.reportViewer1.RefreshReport();
        }
    }
}

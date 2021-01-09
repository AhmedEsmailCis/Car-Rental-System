using System;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void AddingNewCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCar a = new addCar();
            a.ShowDialog();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADMIN a = new ADMIN();
            a.logout(this);
        }

        private void AddingNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCustomer a = new addCustomer();
            a.ShowDialog();
        }

        private void EditYourInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAdminInformation u = new UpdateAdminInformation();
            u.ShowDialog();
        }

        private void EditTheExistingCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateCustomer u = new updateCustomer();
            u.ShowDialog();
        }

        private void viewDetailsOfTheCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchCustomer s = new searchCustomer();
            s.ShowDialog();
        }

        private void listOfAllCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listOfAllCustomers s = new listOfAllCustomers();
            s.ShowDialog();
        }

        private void repotForAllCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportOfAllCustomers r = new reportOfAllCustomers();
            r.ShowDialog();
        }

        private void AddingNewBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addBooking a = new addBooking();
            a.ShowDialog();
        }

        private void EditTheExistingBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateBooking u = new updateBooking();
            u.ShowDialog();
        }

        private void viewDetailsOfBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchBooking s = new searchBooking();
            s.ShowDialog();
        }

        private void listOfAllBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listOfAllBooking l = new listOfAllBooking();
            l.ShowDialog();
        }

        private void deleteBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteBooking d = new deleteBooking();
            d.ShowDialog();
        }

        private void reportForAllBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportOfAllBooking r = new reportOfAllBooking();
            r.ShowDialog();
        }

        private void EdittheExistingCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateCar u = new updateCar();
            u.ShowDialog();
        }

        private void viewDetailsOfTheCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchCar s = new searchCar();
            s.ShowDialog();
        }

        private void listOfAllCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listOfAllCar l = new listOfAllCar();
            l.ShowDialog();
        }

        private void deleteCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteCar d = new deleteCar();
            d.ShowDialog();
        }

        private void repotForAllCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportOfAllCars r = new reportOfAllCars();
            r.ShowDialog();
        }
    }
}

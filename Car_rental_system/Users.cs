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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            addCustomerByHimself a = new addCustomerByHimself();
            a.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateCustomerByHimself u = new updateCustomerByHimself();
            u.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            addBookingByUser a = new addBookingByUser();
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateBookingByUser u = new updateBookingByUser();
            u.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m = new main();
            m.ShowDialog();
        }
    }
}

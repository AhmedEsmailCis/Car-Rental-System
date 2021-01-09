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
    public partial class addBookingByUser : Form
    {
        public addBookingByUser()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Users u = new Users();
            u.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CUSTOMER c = new CUSTOMER();
            c.Bk = new BOOKING(dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            c.Bk.add_booking(textBox3.Text, textBox4.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}

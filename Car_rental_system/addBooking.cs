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
    public partial class addBooking : Form
    {
        public addBooking()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADMIN a = new ADMIN();
            a.Bk = new BOOKING(dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            a.Bk.add_booking(textBox3.Text, textBox4.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}

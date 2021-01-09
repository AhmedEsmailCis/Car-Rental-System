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
    public partial class addCustomerByHimself : Form
    {
        public addCustomerByHimself()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users u = new Users();
            u.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CUSTOMER Cus = new CUSTOMER(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            Cus.add_customer();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}

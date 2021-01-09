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
    public partial class searchCustomer : Form
    {
        public searchCustomer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ADMIN a = new ADMIN();
            a.Cus = new CUSTOMER(textBox1.Text);
            dataGridView1.DataSource = a.Cus.search_customer();
        }
    }
}

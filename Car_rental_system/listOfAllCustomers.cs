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
    public partial class listOfAllCustomers : Form
    {
        public listOfAllCustomers()
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
            a.Cus = new CUSTOMER();
            dataGridView1.DataSource = a.Cus.listOfAll_customers();
        }
    }
}

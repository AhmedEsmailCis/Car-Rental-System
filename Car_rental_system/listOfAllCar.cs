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
    public partial class listOfAllCar : Form
    {
        public listOfAllCar()
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
            a.Cr = new CAR();
            dataGridView1.DataSource = a.Cr.listOfAll_cars();
        }
    }
}

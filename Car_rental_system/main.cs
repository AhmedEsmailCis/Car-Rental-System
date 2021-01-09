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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users U = new Users();
            U.ShowDialog();
        }
    }
}

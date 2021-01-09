using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Car_rental_system
{
    public partial class Login : Form
    {
        public Login()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ADMIN a = new ADMIN(textBox1.Text, textBox2.Text);
            //a.login(this);
            this.Hide();
            Admin a = new Admin();
            a.ShowDialog();
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            main m = new main();
            m.ShowDialog();
        }


      
    }
}

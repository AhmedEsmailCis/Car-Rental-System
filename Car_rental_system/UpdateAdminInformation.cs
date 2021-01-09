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
    public partial class UpdateAdminInformation : Form
    {
        public UpdateAdminInformation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox4.Text== textBox5.Text)
            {
                ADMIN a = new ADMIN(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                a.edit_information();
            }
            else
                MessageBox.Show("Passwords do not match...check it.");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }
    }
}

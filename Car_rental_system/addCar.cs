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
    public partial class addCar : Form
    {
        public addCar()
        {
            InitializeComponent();
            fullcobo();
        }
        void fullcobo()
        {
            SqlConnection con = new SqlConnection("Data Source=ISLAM\\SQLEXPRESS;Initial Catalog=CarRentalSystem;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("select Type_t from TypesOfCars", con);
            SqlDataReader dr;
            com.CommandType = CommandType.Text;
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Type_t"]);
            }
            comboBox1.DisplayMember = "car types";
            dr.Close();

            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADMIN a = new ADMIN();
            a.Cr = new CAR(textBox1.Text,comboBox1.Text,textBox2.Text, textBox3.Text);
            a.Cr.add_car();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}

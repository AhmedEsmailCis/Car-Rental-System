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
    public partial class deleteBooking : Form
    {
        public deleteBooking()
        {
            InitializeComponent();
            fullcobo();
        }
        void fullcobo()
        {
            SqlConnection con = new SqlConnection("Data Source=ISLAM\\SQLEXPRESS;Initial Catalog=CarRentalSystem;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("select Booking_id_b from Booking", con);
            SqlDataReader dr;
            com.CommandType = CommandType.Text;
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Booking_id_b"]);
            }
            comboBox1.DisplayMember = "Booking Id";
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
            a.Bk = new BOOKING(Convert.ToInt32(comboBox1.Text));
            a.Bk.delete_booking();
        }
    }
}

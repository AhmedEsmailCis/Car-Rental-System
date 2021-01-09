using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_rental_system
{
    class BOOKING
    {
        private int Booking_id;
        private DateTime Start;
        private DateTime End;
        private double T_cost;
        private double T_deposited;
        private SqlConnection con;
        public BOOKING()
        {
            Booking_id = 0;
            T_cost = 0.0;
            T_deposited = 0.0;
            con = new SqlConnection("Data Source=AHMED;Initial Catalog=CarRentalSystem;Integrated Security=True");
            con.Open();
        }
        public BOOKING(int Booking_id)
        {
            this.Booking_id = Booking_id;
            con = new SqlConnection("Data Source=AHMED;Initial Catalog=CarRentalSystem;Integrated Security=True");
            con.Open();
        }
        public BOOKING(DateTime Start, DateTime End, double T_cost, double T_deposited)
        {
            this.Start = Start;
            this.End = End;
            this.T_cost = T_cost;
            this.T_deposited = T_deposited;
            con = new SqlConnection("Data Source=AHMED;Initial Catalog=CarRentalSystem;Integrated Security=True");
            con.Open();
        }
        public BOOKING(int Booking_id, DateTime Start, DateTime End, double T_cost, double T_deposited)
        {
            this.Booking_id = Booking_id;
            this.Start = Start;
            this.End = End;
            this.T_cost = T_cost;
            this.T_deposited = T_deposited;
            con = new SqlConnection("Data Source=AHMED;Initial Catalog=CarRentalSystem;Integrated Security=True");
            con.Open();
        }
        public void add_booking(string Ussn, string Cplat)
        {
            try
            {
                string insert = @"insert into Booking(Start_b,End_b,T_cost_b,T_deposited_b,Ssn_u_b,CarPlate_c_b)
                values(@start,@end,@t_cost,@t_deposited,@s,@c)";
                SqlCommand cmd = new SqlCommand(insert, con);
                SqlParameter start = new SqlParameter("@start", Start);
                cmd.Parameters.Add(start);
                SqlParameter end = new SqlParameter("@end", End);
                cmd.Parameters.Add(end);
                SqlParameter Total_cost = new SqlParameter("@t_cost", T_cost);
                cmd.Parameters.Add(Total_cost);
                SqlParameter Total_deposited = new SqlParameter("@t_deposited", T_deposited);
                cmd.Parameters.Add(Total_deposited);
                SqlParameter UserSsn = new SqlParameter("@s", Ussn);
                cmd.Parameters.Add(UserSsn);
                SqlParameter CarPlate = new SqlParameter("@c", Cplat);
                cmd.Parameters.Add(CarPlate);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("SSn Or Car plate are not find");
            }
        }
        public void update_booking(string Ussn, string Cplate)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("UPDATE Booking SET Start_b = @start , End_b = @end , T_cost_b = @cost ,  T_deposited_b = @deposited , Ssn_u_b = @ssn , CarPlate_c_b = @carplate WHERE Booking_id_b =@bookingId ", con);
                cmd.Parameters.AddWithValue("@bookingId", Booking_id);
                cmd.Parameters.AddWithValue("@start", Start);
                cmd.Parameters.AddWithValue("@end", End);
                cmd.Parameters.AddWithValue("@cost", T_cost);
                cmd.Parameters.AddWithValue("@deposited", T_deposited);
                cmd.Parameters.AddWithValue("@ssn", Ussn);
                cmd.Parameters.AddWithValue("@carplate", Cplate);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("SSn Or Car plate are not find");
            }
        }
        public void update_bookingByHimself(string Ussn, string Cplate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Booking SET Start_b = @start , End_b = @end , T_cost_b = @cost ,  T_deposited_b = @deposited , CarPlate_c_b = @carplate WHERE Booking_id_b =@bookingId and Ssn_u_b = @ssn  ", con);
                cmd.Parameters.AddWithValue("@bookingId", Booking_id);
                cmd.Parameters.AddWithValue("@start", Start);
                cmd.Parameters.AddWithValue("@end", End);
                cmd.Parameters.AddWithValue("@cost", T_cost);
                cmd.Parameters.AddWithValue("@deposited", T_deposited);
                cmd.Parameters.AddWithValue("@ssn", Ussn);
                cmd.Parameters.AddWithValue("@carplate", Cplate);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("SSn Or Car plate are not find");
            }

        }
        public DataTable search_booking()
        {
            SqlCommand cmd = new SqlCommand(" select * from Booking where Booking_id_b=@Booking_id", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Booking_id", Booking_id);
            // cmd.Parameters.Add("@Booking_id", SqlDbType.Int).Value = ComboBox1.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Columns.Add(" Booking ID ");
            tbl.Columns.Add(" Start Date ");
            tbl.Columns.Add(" End Date");
            tbl.Columns.Add(" Total Cost ");
            tbl.Columns.Add(" Total Deposited ");
            tbl.Columns.Add(" Cust Id ");
            tbl.Columns.Add(" Car Plate ");
            DataRow Row;
            while (reader.Read())
            {
                Row = tbl.NewRow();
                Row[0] = reader[0];
                Row[1] = reader[1];
                Row[2] = reader[2];
                Row[3] = reader[3];
                Row[4] = reader[4];
                Row[5] = reader[5];
                Row[6] = reader[6];
                tbl.Rows.Add(Row);

            }
            reader.Close();
            return tbl;
        }
        public void delete_booking()
        {
            DialogResult res = MessageBox.Show("Are you Sure you Want To Delete This Booking ?!", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand(" delete from Booking where Booking_id_b=@Booking_id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Booking_id", Booking_id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("deleted...");
            }
            else
            {
                MessageBox.Show("Operation is Cancelled....");
            }
        }
        public DataTable listOfAll_bookings()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select Booking_id_b,Start_b,End_b from Booking", con);
            da.Fill(dt);
            return dt;
        }
        ~BOOKING()
        {
            con.Close();
        }
    }
}

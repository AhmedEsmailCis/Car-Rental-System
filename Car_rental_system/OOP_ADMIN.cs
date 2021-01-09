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
    class ADMIN : PERSON
    {
        private string UserName;
        private string Password;
        public CUSTOMER Cus;
        public CAR Cr;
        public BOOKING Bk;
        private SqlConnection con;
        public ADMIN() : base()
        {
            UserName = "";
            Password = "";
            con = new SqlConnection("Data Source=AHMED;Initial Catalog=CarRentalSystem;Integrated Security=True");
            con.Open();
        }
        public ADMIN(string UserName, string Password) : base()
        {
            this.UserName = UserName;
            this.Password = Password;
            con = new SqlConnection("Data Source=AHMED;Initial Catalog=CarRentalSystem;Integrated Security=True");
            con.Open();
        }
        public ADMIN(string Ssn, string Name, string UserName, string Password) : base(Ssn, Name)
        {
            this.UserName = UserName;
            this.Password = Password;
            con = new SqlConnection("Data Source=AHMED;Initial Catalog=CarRentalSystem;Integrated Security=True");
            con.Open();
        }
        public void login(Login form)
        {
            SqlCommand cmd = new SqlCommand("select UserName_a,Password_a from Admin where UserName_a=@UserName and Password_a=@Password ", con);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            SqlDataReader rdr = cmd.ExecuteReader();
            int count = 0;
            while (rdr.Read())
            {
                count += 1;
            }
            if (count == 1)
            {
                form.Hide();
                Admin a = new Admin();
                a.ShowDialog();
            }
            else if (count > 1)
            {
                MessageBox.Show("Duplicate UserName and Password ... access database.");
            }
            else
            {
                MessageBox.Show("UserName and Password are not correct.");
            }
            rdr.Close();
        }
        public void edit_information()
        {
            SqlCommand cmd = new SqlCommand("UPDATE Admin SET Name_a = @name , UserName_a = @username , Password_a = @password WHERE Ssn_a =@ssn ", con);
            cmd.Parameters.AddWithValue("@ssn", Ssn);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@username", UserName);
            cmd.Parameters.AddWithValue("@password", Password);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated");
        }
        public void logout(Admin form)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Logout ?!", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                form.Hide();
                main m = new main();
                m.ShowDialog();
            }
            else
            {
                MessageBox.Show("Operation is Cancelled....");
            }
        }
         ~ADMIN()
        {
            con.Close();
        }
    }
}

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
    class CUSTOMER : PERSON
    {
        private string Phone;
        private string Address;
        private string LicenseNum;
        public BOOKING Bk;
        private SqlConnection con;
        public CUSTOMER(): base()
        {
            Phone = "";
            Address = "";
            LicenseNum = "";
            con = new SqlConnection("Data Source=AHMED;Initial Catalog=CarRentalSystem;Integrated Security=True");
            con.Open();
        }
        public CUSTOMER(string Ssn): base(Ssn)
        {
            Phone = "";
            Address = "";
            LicenseNum = "";
            con = new SqlConnection("Data Source=AHMED;Initial Catalog=CarRentalSystem;Integrated Security=True");
            con.Open();
        }
        public CUSTOMER(string Ssn, string Name, string Phone, string Address, string LicenseNum): base(Ssn, Name)
        {
            this.Phone = Phone;
            this.Address = Address;
            this.LicenseNum = LicenseNum;
            con = new SqlConnection("Data Source=AHMED;Initial Catalog=CarRentalSystem;Integrated Security=True");
            con.Open();
        }
        public void add_customer()
        {
            string insert = @"insert into Users(Ssn_u,Name_u,Phone_u,Address_u,LicenseNum_u)
            values(@SSN,@name,@phone,@address,@license)";
            SqlCommand cmd = new SqlCommand(insert, con);
            SqlParameter sotial = new SqlParameter("@SSN", Ssn);
            cmd.Parameters.Add(sotial);
            SqlParameter name = new SqlParameter("@name", Name);
            cmd.Parameters.Add(name);
            SqlParameter phone = new SqlParameter("@phone", Phone);
            cmd.Parameters.Add(phone);
            SqlParameter address = new SqlParameter("@address", Address);
            cmd.Parameters.Add(address);
            SqlParameter license = new SqlParameter("@license", LicenseNum);
            cmd.Parameters.Add(license);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added...");
        }
        public void update_customer()
        {
            SqlCommand cmd = new SqlCommand("UPDATE Users SET  Name_u = @name , Phone_u = @phone ,Address_u = @address ,LicenseNum_u = @license WHERE Ssn_u =@ssn ", con);
            cmd.Parameters.AddWithValue("@ssn", Ssn);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@phone", Phone);
            cmd.Parameters.AddWithValue("@address", Address);
            cmd.Parameters.AddWithValue("@license", LicenseNum);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated");
        }
        public DataTable search_customer()
        {
            SqlCommand cmd = new SqlCommand(" select * from Users where Ssn_u=@SSn", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@SSn", Ssn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Columns.Add(" ID Card ");
            tbl.Columns.Add(" Name ");
            tbl.Columns.Add(" Phone ");
            tbl.Columns.Add(" Address ");
            tbl.Columns.Add(" License Number ");
            DataRow Row;
            while (reader.Read())
            {
                Row = tbl.NewRow();
                Row[0] = reader[0];
                Row[1] = reader[1];
                Row[2] = reader[2];
                Row[3] = reader[3];
                Row[4] = reader[4];
                tbl.Rows.Add(Row);

            }
            reader.Close();
            return tbl;

        }
        public DataTable listOfAll_customers()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select Ssn_u,Name_u from Users", con);
            da.Fill(dt);
            return dt; ;

        }
        ~CUSTOMER()
        {
            con.Close();
        }

    }
}

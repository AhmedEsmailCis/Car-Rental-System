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
    class CAR
    {
        private string CarPlate;
        private string Type;
        private string Model;
        private string ModelYear;
        private int NumOfCars;
        private SqlConnection con;
        public CAR()
        {
            CarPlate = "";
            Type = "";
            Model = "";
            ModelYear = "";
            NumOfCars = 0;
            con = new SqlConnection("Data Source=AHMED;Initial Catalog=CarRentalSystem;Integrated Security=True");
            con.Open();
        }
        public CAR(string CarPlate)
        {
            this.CarPlate = CarPlate;
            con = new SqlConnection("Data Source=AHMED;Initial Catalog=CarRentalSystem;Integrated Security=True");
            con.Open();
        }
        public CAR(string Type, int NumOfCars)
        {
            this.Type = Type;
            this.NumOfCars = NumOfCars;
            con = new SqlConnection("Data Source=AHMED;Initial Catalog=CarRentalSystem;Integrated Security=True");
            con.Open();
        }
        public CAR(string CarPlate, string Type, string Model, string ModelYear)
        {
            this.CarPlate = CarPlate;
            this.Type = Type;
            this.Model = Model;
            this.ModelYear = ModelYear;
            con = new SqlConnection("Data Source=AHMED;Initial Catalog=CarRentalSystem;Integrated Security=True");
            con.Open();
        }
        public void add_car()
        {
            string insert = @"insert into Cars(CarPlate_c,Type_t_c,Model_c,ModelYars_c)
                Values(@CarPlate,@type_c,@model_c,@model_year)";
            SqlCommand cmd = new SqlCommand(insert, con);
            SqlParameter plate = new SqlParameter("@CarPlate", CarPlate);
            cmd.Parameters.Add(plate);
            SqlParameter type = new SqlParameter("@type_c", Type);
            cmd.Parameters.Add(type);
            SqlParameter model = new SqlParameter("@model_c", Model);
            cmd.Parameters.Add(model);
            SqlParameter modyear = new SqlParameter("@model_year", ModelYear);
            cmd.Parameters.Add(modyear);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added...");
        }
        public void update_car()
        {
            SqlCommand cmd = new SqlCommand("UPDATE Cars SET Type_t_c = @type , Model_c = @model , ModelYars_c = @mYears WHERE CarPlate_c =@carplate ", con);
            cmd.Parameters.AddWithValue("@carplate", CarPlate);
            cmd.Parameters.AddWithValue("@type", Type);
            cmd.Parameters.AddWithValue("@model", Model);
            cmd.Parameters.AddWithValue("@mYears", ModelYear);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated");
        }
        public void update_Typescar()
        {
            SqlCommand cmd = new SqlCommand("UPDATE TypesOfCars SET NumOfCars_t = @num  WHERE Type_t =@type ", con);
            cmd.Parameters.AddWithValue("@type", Type);
            cmd.Parameters.AddWithValue("@num", NumOfCars);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated");
        }
        public DataTable search_car()
        {
            SqlCommand cmd = new SqlCommand(" select * from Cars where CarPlate_c=@CarPlate", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@CarPlate", CarPlate);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Columns.Add(" Car Plate ");
            tbl.Columns.Add(" Type ");
            tbl.Columns.Add(" Model ");
            tbl.Columns.Add(" Number ");
            DataRow Row;
            while (reader.Read())
            {
                Row = tbl.NewRow();
                Row[0] = reader[0];
                Row[1] = reader[1];
                Row[2] = reader[2];
                Row[3] = reader[3];
                tbl.Rows.Add(Row);

            }
            reader.Close();
            return tbl;
        }
        public void delete_car()
        {
            DialogResult res = MessageBox.Show("Are you Sure you Want to Delete This Car ?!", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(" delete from Cars where CarPlate_c=@CarPlate", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@CarPlate", CarPlate);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("deleted...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("this car cannot deleted because it booked....frist delete its booking.");
                }
            }
            else
            {
                MessageBox.Show("Operation is Cancelled....");
            }
        }
        public DataTable listOfAll_cars()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from Cars", con);
            da.Fill(dt);
            return dt;
        }
        ~CAR()
        {
            con.Close();
        }
    }
}

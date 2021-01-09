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
    class PERSON 
    {
        protected string Ssn;
        protected string Name; 
        public PERSON()
        {
            Ssn = "";
            Name = "";
        }
        public PERSON(string Ssn)
        {
            this.Ssn = Ssn;
        }
        public PERSON(string Ssn, string Name)
        {
            this.Ssn = Ssn;
            this.Name = Name;
        }
    }
}
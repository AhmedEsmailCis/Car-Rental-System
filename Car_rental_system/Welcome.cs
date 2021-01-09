using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Car_rental_system
{
    public partial class Welcome : Form
    {
        public Welcome()
        {


            Thread t = new Thread(new ThreadStart(splashstart));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();

            t.Abort();
        }
        public void splashstart()
        {
            Application.Run(new Loading());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m = new main();
            m.ShowDialog();
        }

        
    }
}

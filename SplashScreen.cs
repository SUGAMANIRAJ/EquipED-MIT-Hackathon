using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Project_Library
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);

            if (progressBar1.Value == 99)
            {
                this.Hide();
                Form1 form = new Form1();
                form.Show();
               
            }

        }
    }
}


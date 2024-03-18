using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Library
{
    public partial class Interfaces : Form
    {
        public Interfaces()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Dash dash = new Dash();
            dash.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            DashComputer dashComputer = new DashComputer(); 
            dashComputer.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            DashSoftware dashSoftware = new DashSoftware();
            dashSoftware.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Notifyab notifyab = new Notifyab(); 
            notifyab.Show();    
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Click(object sender, EventArgs e)
        {
            feed ffed = new feed(); 
            ffed.Show();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback(); 
            feedback.Show();    
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterStudent reg= new RegisterStudent();
            reg.Show();
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudent mstu = new ManageStudent();   
            mstu.Show();    
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            IssueBooks issueBooks = new IssueBooks();
            issueBooks.Show();
        }
    }
}

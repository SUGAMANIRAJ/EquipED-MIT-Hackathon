using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Library
{
    public partial class feed : Form
    {
        public feed()
        {
            InitializeComponent();
        }

        private void feed_Load(object sender, EventArgs e)
        {


        }

       
            private void button1_Click(object sender, EventArgs e)
            {



                if (name.Text != "" && reg.Text != "" && dept.Text != "" && feedback.Text != "")
                {

                    string Nname = name.Text;
                    string Reg = reg.Text;
                    string Dept = dept.Text;
                    string Feedback = feedback.Text;

                    SqlConnection con1 = new SqlConnection();
                    con1.ConnectionString = "Data source=STORMER-TECH\\SQLEXPRESS ; database=LibX ;Integrated Security=True ";
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = con1;
                    con1.Open();
                    cmd1.CommandText = "Insert into Feedback (Student_Name,Register_Number,Dept,Feedback) values ( '" + Nname + "','" + Reg + "','" + Dept + "'  , '" + Feedback + "' )";
                    cmd1.ExecuteNonQuery();
                    con1.Close();


                    MessageBox.Show("Feedback sent successfully!", "Success", MessageBoxButtons.OK);

                name.Clear();
                reg.Clear();
                dept.Clear();
                feedback.Clear();



                }

            }

            
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=STORMER-TECH\\SQLEXPRESS ; database=LibX; integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText="Select * from Login where UserName ='"+user.Text+"' and Password='"+passcode.Text+"'    ";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count != 0)
            {

                welcome wel = new welcome();
                wel.Show();
                this.Hide();
              
            }
            else
            {
                MessageBox.Show("Enter valid User name and password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

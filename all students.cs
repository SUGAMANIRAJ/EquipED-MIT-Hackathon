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
    public partial class all_students : Form
    {
        public all_students()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentinput.Clear();   
        }

        private void studentinput_TextChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0 && studentinput.Text != "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=STORMER-TECH\\SQLEXPRESS ; database=LibX; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " Select * from Students where Registerno like '" + studentinput.Text + "%' ";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];

            }
            else if (comboBox1.SelectedIndex == 1 && studentinput.Text != "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=STORMER-TECH\\SQLEXPRESS ; database=LibX; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " Select * from Students where Name like '" + studentinput.Text + "%' ";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];

            }
            else if (comboBox1.SelectedIndex == 2 && studentinput.Text != "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=STORMER-TECH\\SQLEXPRESS ; database=LibX; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " Select * from Students where Dept like '" + studentinput.Text + "%' ";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];

            }
            else if (comboBox1.SelectedIndex == 3 && studentinput.Text != "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=STORMER-TECH\\SQLEXPRESS ; database=LibX; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " Select * from Students where Sem like '" + studentinput.Text + "%' ";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];

            }
          
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from Students ";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);

                dataGridView1.DataSource = dataset.Tables[0];
            }










        }

        private void all_students_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from Students ";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);

            dataGridView1.DataSource = dataset.Tables[0];
        }
    }
}

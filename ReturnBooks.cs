using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace Project_Library
{
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
        {
            InitializeComponent();
        }

       

       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.SlateBlue, ButtonBorderStyle.Solid);

        }

        int tid;
        int tid1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {

                return;

            }

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                tid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }

            panel1.Visible = true;



            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from IssueBooks where TransactionId='" + tid + "' ";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            tid1 =int.Parse(dataset.Tables[0].Rows[0][0].ToString());

            RegNo.Text = dataset.Tables[0].Rows[0][1].ToString();
            StuName.Text = dataset.Tables[0].Rows[0][2].ToString();
            BookId.Text = dataset.Tables[0].Rows[0][3].ToString();
            BookName.Text = dataset.Tables[0].Rows[0][4].ToString();
            IssueDate.Text = dataset.Tables[0].Rows[0][5].ToString();
            DueDate.Text = dataset.Tables[0].Rows[0][6].ToString();
           
        }

        private void Return_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are u sure u want to return book ", "warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string Returndate=ReturnDate.Text;
                Int64 FineAmt = Int64.Parse(Fine.Text);
                string Status = "Returned";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update IssueBooks set ReturnDate='"+Returndate+"' , Fine='"+FineAmt+"', Status='"+Status+"' where TransactionId='"+tid1+"' ";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);

                panel1.Visible = false;
            }
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {
           panel1.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=STORMER-TECH\\SQLEXPRESS ; database=LibX; integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = " Select * from IssueBooks where  ReturnDate is null ";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
        }

        private void Bookinput_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 && Bookinput.Text != "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=STORMER-TECH\\SQLEXPRESS ; database=LibX; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " Select * from IssueBooks where  ReturnDate is null and BookId like '" + Bookinput.Text + "%' ";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];

            }
            else if (comboBox1.SelectedIndex == 1 && Bookinput.Text != "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=STORMER-TECH\\SQLEXPRESS ; database=LibX; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " Select * from IssueBooks where ReturnDate is null and BookName like '" + Bookinput.Text + "%' ";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];

            }
            else if (comboBox1.SelectedIndex == 2 && Bookinput.Text != "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=STORMER-TECH\\SQLEXPRESS ; database=LibX; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " Select * from IssueBooks where  ReturnDate is null and RegisterNumber like '" + Bookinput.Text + "%' ";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];

            }
            else if (comboBox1.SelectedIndex == 3 && Bookinput.Text != "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=STORMER-TECH\\SQLEXPRESS ; database=LibX; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " Select * from IssueBooks where  ReturnDate is null and StudentName like '" + Bookinput.Text + "%' ";

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

                cmd.CommandText = "Select * from IssueBooks where  ReturnDate is null ";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);

                dataGridView1.DataSource = dataset.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bookinput.Clear();
            panel1.Visible= false;    

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace Project_Library
{
    public partial class ManageStudent : Form
    {
        public ManageStudent()
        {
            InitializeComponent();
        }

        string pattern = "^[^@\\s]+@[^@\\s]+\\.(com|net|org|gov)$";

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;

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

        private void StudentInput_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 && StudentInput.Text != "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=STORMER-TECH\\SQLEXPRESS ; database=LibX; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " Select * from Students where  RegisterNo like '" + StudentInput.Text + "%' ";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];

            }
            else if (comboBox1.SelectedIndex == 1 && StudentInput.Text != "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=STORMER-TECH\\SQLEXPRESS ; database=LibX; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " Select* from Students where  Name like '" + StudentInput.Text + "%' ";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];

            }
            else if (comboBox1.SelectedIndex == 2 && StudentInput.Text != "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=STORMER-TECH\\SQLEXPRESS ; database=LibX; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " Select * from Students where  Sem like '" + StudentInput.Text + "%' ";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];

            }
            else if (comboBox1.SelectedIndex == 3 && StudentInput.Text != "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=STORMER-TECH\\SQLEXPRESS ; database=LibX; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " Select * from Students where  Dept like '" + StudentInput.Text + "%' ";

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




        int bid;
        int bid1;


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) {

                return;
            
            }
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null )
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }

            panel1.Visible = true;
           

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from Students where ID='" + bid + "' ";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);

            bid1 = int.Parse(dataset.Tables[0].Rows[0][0].ToString());

            SReg.Text = dataset.Tables[0].Rows[0][1].ToString();
            SName.Text = dataset.Tables[0].Rows[0][2].ToString();
            SDept.Text = dataset.Tables[0].Rows[0][3].ToString();
            SSem.Text = dataset.Tables[0].Rows[0][4].ToString();
            SCont.Text = dataset.Tables[0].Rows[0][5].ToString();
            SEmail.Text = dataset.Tables[0].Rows[0][6].ToString();


        }








        private void Update_Click(object sender, EventArgs e)
        {
           


            if (SReg.Text != "" && SName.Text != "" && SDept.Text != "" && SSem.Text != "" && SCont.Text != "" && SEmail.Text != "")
            {
                if (Regex.IsMatch(SEmail.Text, pattern) == false)
                {
                    MessageBox.Show("Enter Valid Email ", "warning", MessageBoxButtons.OK);
                }

               else if (SCont.TextLength > 10)
                    {
                        MessageBox.Show("Enter valid Contact Number", "Warning", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (MessageBox.Show("Are u sure u want to update ", "warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            string StuName = SReg.Text;
                            string StuReg = SName.Text;
                            string StuDept = SDept.Text;
                            string StuSem = SSem.Text;
                            Int64 StuCont = Int64.Parse(SCont.Text);
                            string StuEmail = SEmail.Text;




                            SqlConnection con1 = new SqlConnection();
                            con1.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
                            SqlCommand cmd1 = new SqlCommand();
                            cmd1.Connection = con1;

                            cmd1.CommandText = "update Students set Name='" + StuName + "' , RegisterNo='" + StuReg + "' , Dept='" + StuDept + "' , Sem='" + StuSem + "'    , Contact='" + StuCont + "', Email='" + StuEmail + "'  Where ID='" + bid1 + "'   ";
                            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(cmd1);
                            DataSet dataset1 = new DataSet();
                            dataAdapter1.Fill(dataset1);



                        }
                    }
                
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are u sure u want to delete ", "Confimation Dialog", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from Students where ID='" + bid1 + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);




            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
           
        }

     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.SlateBlue, ButtonBorderStyle.Solid);
        }

        private void SCont_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=!char.IsNumber(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInput.Clear();   
           panel1.Visible = false;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

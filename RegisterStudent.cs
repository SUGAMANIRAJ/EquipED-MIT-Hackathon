using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Project_Library
{
    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        string pattern = "^[^@\\s]+@[^@\\s]+\\.(com|net|org|gov)$";
        private void Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are u sure u want to Exit", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                this.Close();


            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            int cc = 0;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();

            cmd.CommandText = "Select * from Students";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            SqlDataReader reader = cmd.ExecuteReader();



                if (SName.Text != "" && SRegisterNo.Text != "" && SDept.Text != "" && SSem.Text != "" && SCont.Text != "" && SEmail.Text != "")
                {



                while (reader.Read())
                {
                    if (reader.GetString(1) == SRegisterNo.Text)
                    {
                        cc = 1;
                    }
                }
                if (cc==1)
                { 


                    MessageBox.Show($"The Register Number : {SRegisterNo.Text}  already registered ", "Warning", MessageBoxButtons.OK);


                }

                else
                {
                    if(Regex.IsMatch(SEmail.Text,pattern)==false)
                    {
                        MessageBox.Show("Enter Valid Email ", "warning", MessageBoxButtons.OK);
                    }

                    else if (SCont.TextLength > 10)
                    {
                        MessageBox.Show("Enter valid Contact Number", "Warning", MessageBoxButtons.OK);
                    }
                    else
                    {
                        string StuName = SName.Text;
                        string StuReg = SRegisterNo.Text;
                        string StuDept = SDept.Text;
                        string StuSem = SSem.Text;
                        Int64 StuCont = Int64.Parse(SCont.Text);
                        string StuEmail = SEmail.Text;

                        SqlConnection con1 = new SqlConnection();
                        con1.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
                        SqlCommand cmd1 = new SqlCommand();
                        cmd1.Connection = con1;

                        cmd1.CommandText = "Insert into Students (RegisterNo,Name,Dept,Sem,Contact,Email) Values ('" + StuReg + "','" + StuName + "','" + StuDept + "','" + StuSem + "','" + StuCont + "','" + StuEmail + "') ";

                        SqlDataAdapter dataAdapter1 = new SqlDataAdapter(cmd1);
                        DataSet dataset1 = new DataSet();
                        dataAdapter1.Fill(dataset1);

                        MessageBox.Show("Student Registered Succesfully ! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SName.Clear();
                        SRegisterNo.Clear();
                        SDept.Text = string.Empty;
                        SSem.Text = string.Empty;
                        SCont.Clear();
                        SEmail.Clear();
                    }
                }
                }
                else
                {
                    MessageBox.Show("Empty Feilds Cant Be accepted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }





            }

        private void SCont_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= !Char.IsNumber(e.KeyChar);
            
        }

        private void RegisterStudent_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics , this.panel1.ClientRectangle , Color.SlateBlue, ButtonBorderStyle.Solid);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, Color.SlateBlue, ButtonBorderStyle.Solid);
        
    }
    }
    }


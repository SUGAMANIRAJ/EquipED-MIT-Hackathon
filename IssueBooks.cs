using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_Library
{
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, Color.SlateBlue, ButtonBorderStyle.Solid);
        }

        int flag = 0;
        int flag1 = 0;

        private void Stu_Click(object sender, EventArgs e)
        {
            flag = 0;
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

            while (reader.Read())
            {

                if (reader.GetString(1) == SearchStu.Text)
                {
                    SName.Text =reader.GetString(2);
                    SDept.Text = reader.GetString(3);
                    SSem.Text = reader.GetString(4);
                    SCont.Text = reader.GetString(5);
                    SEmail.Text = reader.GetString(6);

                    flag = 1;

                    
                }
            }
            reader.Close();
            con.Close(); 
            if(flag == 0)
            {
               
                MessageBox.Show("Invalid Student","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
                SName.Clear();
                SDept.Clear();
                SEmail.Clear();
                SSem.Clear();
                SCont.Clear();
                
               
            }



        }

        private void Book_Click(object sender, EventArgs e)
        {
            flag1 = 0;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();

            cmd.CommandText = "Select * from Books";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                if (reader.GetString(1) == SearchBook.Text)
                {

                    BName.Text = reader.GetString(2);
                    BAuthor.Text = reader.GetString(3);
                    BGenre.Text = reader.GetString(5);
                    BPublication.Text = reader.GetString(4);
                    BDate.Text = reader.GetString(6);
                    BPrice.Text = reader.GetValue(7).ToString();
                    BQuantity.Text = reader.GetValue(8).ToString();


                    flag1 = 1;


                }
            }
            reader.Close();
            con.Close();
            if (flag1 == 0)
            {

                BName.Clear();
                BAuthor.Clear();
                BGenre.Clear();
                BPublication.Clear();
                BDate.Clear();
                BPrice.Clear();
                BQuantity.Clear();
                MessageBox.Show("Invalid Book", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string StuReg = SearchStu.Text;
            string bookid = SearchBook.Text;    


            int count;
            if (flag == 1 && flag1 == 1 && StuReg!="" && bookid !="" && SName.Text!="" && BName.Text != "")
            {
                

                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;

                con1.Open();

                cmd1.CommandText = "Select Count(RegisterNumber) from IssueBooks where RegisterNumber='" + StuReg + "' and ReturnDate is null  ";

                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                DataSet dataset1 = new DataSet();
                adapter1.Fill(dataset1);

                count = int.Parse(dataset1.Tables[0].Rows[0][0].ToString());

                if (count < 5)
                {

                    if (Duedate.Value.Date >= Issuedate.Value.Date)
                    {


                        if (MessageBox.Show("Are sure to issue kit \n Issue Date " + Issuedate.Value + "\nDue Date " + Duedate.Value, "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {


                            string StuName = SName.Text;
                            string RegNo = SearchStu.Text;
                            string Email = SEmail.Text;
                            string BookName = BName.Text;
                            string BookId = SearchBook.Text;
                            string IssueDate = Issuedate.Text;
                            string DueDate = Duedate.Text;

                            string Status = "Pending";
                            SqlConnection con = new SqlConnection();
                            con.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = con;
                            con.Open();
                            cmd.CommandText = "Insert into IssueBooks (RegisterNumber,StudentName,Email,BookId,BookName,IssueDate,DueDate,Status) Values ( '" + RegNo + "','" + StuName + "','" + Email + "','" + BookId + "','" + BookName + "',  '" + IssueDate + "', '" + DueDate + "','" + Status + "')";
                            cmd.ExecuteNonQuery();
                            con.Close();


                            MessageBox.Show("Kit Issued Successfully !", "Success", MessageBoxButtons.OK);

                            SName.Clear();
                            SDept.Clear();
                            SSem.Clear();
                            SCont.Clear();
                            SEmail.Clear();
                            BName.Clear();
                            BAuthor.Clear();
                            BGenre.Clear();
                            BPublication.Clear();
                            BDate.Clear();
                            BPrice.Clear();
                            BQuantity.Clear();
                             SearchBook.Clear();
                           SearchStu.Clear();


                        }

                    }

                    else
                    {
                        MessageBox.Show("Check the Due Date Properly ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

                else
                {

                    MessageBox.Show("Maximum Limit of Kit is Already isssued to this Student", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SName.Clear();
                    SDept.Clear();
                    SSem.Clear();
                    SCont.Clear();
                    SEmail.Clear();
                    BName.Clear();
                    BAuthor.Clear();
                    BGenre.Clear();
                    BPublication.Clear();
                    BDate.Clear();
                    BPrice.Clear();
                    BQuantity.Clear();
                    SearchBook.Clear();
                    SearchStu.Clear();
                }

            }
            else
            {
                MessageBox.Show("Select Valid Student or Kit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are u sure to exit", "Warning", MessageBoxButtons.OK);
            this.Close();   
        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.SlateBlue, ButtonBorderStyle.Solid);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Duedate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

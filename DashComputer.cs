using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Library
{
    public partial class DashComputer : Form
    {


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public DashComputer()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, Width, Height, 30, 30));
            this.AllowTransparency = true;
        }





      


        private void Bookinput_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 && Bookinput.Text != "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=STORMER-TECH\\SQLEXPRESS ; database=LibX; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " Select * from Books where BID like '" + Bookinput.Text + "%' ";

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

                cmd.CommandText = " Select * from Books where BName like '" + Bookinput.Text + "%' ";

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

                cmd.CommandText = " Select * from Books where BAuthor like '" + Bookinput.Text + "%' ";

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

                cmd.CommandText = " Select * from Books where BPublication like '" + Bookinput.Text + "%' ";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];

            }
            else if (comboBox1.SelectedIndex == 4 && Bookinput.Text != "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=STORMER-TECH\\SQLEXPRESS ; database=LibX; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " Select * from Books where BGenre like '" + Bookinput.Text + "%' ";

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

                cmd.CommandText = "Select * from Books ";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);

                dataGridView1.DataSource = dataset.Tables[0];
            }
        }






        private void Dash_Load(object sender, EventArgs e)
        {
            FillChart();

            SqlConnection con9 = new SqlConnection();
            con9.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
            SqlCommand cmd9 = new SqlCommand();
            cmd9.Connection = con9;

            cmd9.CommandText = "Select * from Computer ";

            SqlDataAdapter dataAdapter9 = new SqlDataAdapter(cmd9);
            DataSet dataset9 = new DataSet();
            dataAdapter9.Fill(dataset9);

            dataGridView1.DataSource = dataset9.Tables[0];


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from Books ";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);

            bcount.Text = $"{dataset.Tables[0].Rows.Count}";

            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con1;

            cmd1.CommandText = "Select * from Students ";

            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(cmd1);
            DataSet dataset1 = new DataSet();
            dataAdapter1.Fill(dataset1);

           

            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con2;

            cmd2.CommandText = "Select * from IssueBooks ";

            SqlDataAdapter dataAdapter2 = new SqlDataAdapter(cmd2);
            DataSet dataset2 = new DataSet();
            dataAdapter2.Fill(dataset2);

  
            SqlConnection con3 = new SqlConnection();
            con3.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = con3;

            cmd3.CommandText = "Select * from IssueBooks where DueDate < '" + DateTime.Today + "' and ReturnDate is null ";

            SqlDataAdapter dataAdapter3 = new SqlDataAdapter(cmd3);
            DataSet dataset3 = new DataSet();
            dataAdapter3.Fill(dataset3);

            





            

        }

      


        private bool mouseDown;
        private Point lastLocation;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to logout", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bookinput.Clear();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            AddBooks addBooks = new AddBooks();
            addBooks.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {
           EditBooks editBooks = new EditBooks();
            editBooks.Show();
        }
        private void label3_Click(object sender, EventArgs e)
        {
          RegisterStudent registerStudent = new RegisterStudent();
            registerStudent.Show();
        }
        private void label4_Click(object sender, EventArgs e)
        {
           ManageStudent manageStudent = new ManageStudent();
            manageStudent.Show();
        }
        private void label5_Click(object sender, EventArgs e)
        {
           IssueBooks issues = new IssueBooks();
            issues.Show();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            ReturnBooks returnBooks = new ReturnBooks();
            returnBooks.Show();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            
        }
        private void label8_Click(object sender, EventArgs e)
        {
            DefaultersList defaultersList = new DefaultersList();
            defaultersList.Show();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
           
           AddBooks addBooks = new AddBooks();
            addBooks.Show();
        }
        private void panel3_Click(object sender, EventArgs e)
        {
           EditBooks editBooks = new EditBooks();
            editBooks.Show();
        }
        private void panel4_Click(object sender, EventArgs e)
        {
            RegisterStudent registerStudent = new RegisterStudent();
            registerStudent.Show();
        }
        private void panel5_Click(object sender, EventArgs e)
        {
            ManageStudent manageStudent = new ManageStudent();  
            manageStudent.Show();
        }
        private void panel6_Click(object sender, EventArgs e)
        {
           IssueBooks issueBooks = new IssueBooks();
            issueBooks.Show();
        }
        private void panel7_Click(object sender, EventArgs e)
        {
            ReturnBooks returnBooks = new ReturnBooks();
            returnBooks.Show();
        }
        private void panel8_Click(object sender, EventArgs e)
        {
           DefaultersList defaultersList = new DefaultersList();
            defaultersList.Show();
        }
        private void panel9_Click(object sender, EventArgs e)
        {
            noduegenerator noduegenerator = new noduegenerator();
            noduegenerator.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void studentHistoryCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
           noduegenerator studentGenerator = new noduegenerator();
            studentGenerator.Show();
        }

        void FillChart()
        {

            SqlConnection con10 = new SqlConnection();
            con10.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
            SqlCommand cmd10 = new SqlCommand();
            cmd10.Connection = con10;
            cmd10.CommandText = "Select * from Books ";

            SqlDataAdapter dataAdapter10 = new SqlDataAdapter(cmd10);
            DataSet dataset10 = new DataSet();
            dataAdapter10.Fill(dataset10);

           
            chart1.DataSource = dataset10;

            chart1.Series["Genre"].XValueMember = "BGenre";
            

            chart1.Series["Genre"].YValueMembers = "Quantity";
           
         








        }

        private void Addbooks_Click(object sender, EventArgs e)
        {
            AddBooks addbooks = new AddBooks();
            addbooks.Show();

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void ManageBooks_Click(object sender, EventArgs e)
        {
            EditBooks editBooks = new EditBooks();  
            editBooks.Show();
        }

        private void registerStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterStudent student = new RegisterStudent();
            student.Show();
        }

        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudent manageStudent = new ManageStudent();
            manageStudent.Show();
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBooks issueBooks = new IssueBooks();
            issueBooks.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBooks returnBooks = new ReturnBooks();    
            returnBooks.Show();
        }

        private void defaultersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultersList defaultersList = new DefaultersList();       
            defaultersList.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
        
}

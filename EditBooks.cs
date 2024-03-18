using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Library
{
    public partial class EditBooks : Form
    {
        public EditBooks()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.SlateBlue, ButtonBorderStyle.Solid);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are u sure u want to delete ", "Confimation Dialog",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from Books where ID='" + bid1 + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);

               


            }
        }

        private void EditBooks_Load(object sender, EventArgs e)
        {   
            panel1.Visible = false;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from Computer ";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);  
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);

            dataGridView1.DataSource = dataset.Tables[0];




        }

       

      
        string bid;
        string bid1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {

                return;

            }


            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid =dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            }

            panel1.Visible = true;

           

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from Books where ID='"+bid+"' "  ;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);

            bid1 = dataset.Tables[0].Rows[0][0].ToString();

            Bookid.Text=dataset.Tables[0].Rows[0][1].ToString();
            BName.Text = dataset.Tables[0].Rows[0][2].ToString();
            BAuthor.Text = dataset.Tables[0].Rows[0][3].ToString();
            BGenre.Text = dataset.Tables[0].Rows[0][4].ToString();
            BPublication.Text = dataset.Tables[0].Rows[0][5].ToString();
            Bdate.Text = dataset.Tables[0].Rows[0][6].ToString();
            BPrice.Text = dataset.Tables[0].Rows[0][7].ToString();
            BQuantity.Text = dataset.Tables[0].Rows[0][8].ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are u sure u want to update ", "warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string BookId = Bookid.Text;
                string BookName = BName.Text;
                string BookAuthor = BAuthor.Text;
                string BookGenre = BGenre.Text;
                string BookPublication = BPublication.Text;
                string BookDateofPurchase = Bdate.Text;
                Int64 BookPrice = Int64.Parse(BPrice.Text);
                Int64 BookQuantity = Int64.Parse(BQuantity.Text);



                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update Books set BId='"+BookId+"', BName='"+BookName+"' , BAuthor='" +BookAuthor+ "' , BGenre='" +BookGenre+ "' ,BPublication='"+BookPublication+"'    ,Dateofpurchase='" + BookDateofPurchase+"',Price='" + BookPrice+  "',Quantity='"+BookQuantity+"' Where ID='" +bid1+ "'   ";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            Bookinput.Clear();
            panel1.Visible = false; 
        }

        private void Manage_Click(object sender, EventArgs e)
        {

        }

        private void Bdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

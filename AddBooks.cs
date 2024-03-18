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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Price_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }

        private void Addbookbtn_Click(object sender, EventArgs e)
        {
            int cc = 0;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();

            cmd.CommandText = "Select * from Computer";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            SqlDataReader reader = cmd.ExecuteReader();


            if (Bookid.Text!=""&& BookName.Text != "" && AuthorName.Text != "" && GenreName.Text!="" && PublicationName.Text != "" && Dateofpurchase.Text != "" && BookPrice.Text != "0" &&  Bookquantity.Text != "0"  ) {


               


                    string BId = Bookid.Text;
                    string BName = BookName.Text;
                    string BAuthor = AuthorName.Text;
                    string BGenre = GenreName.Text;
                    string BPublication = PublicationName.Text;
                    string DateofPurchase = Dateofpurchase.Text;
                    Int64 BPrice = Int64.Parse(BookPrice.Text);
                    Int64 BQuantity = Int64.Parse(Bookquantity.Text);


                    SqlConnection con1 = new SqlConnection();
                    con1.ConnectionString = "Data source=STORMER-TECH\\SQLEXPRESS ; database=LibX ;Integrated Security=True ";
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = con1;
                    con1.Open();
                    cmd1.CommandText = "Insert into Computer (Computer_ID,Computer_Name,Manufacturer,Processor,Storage,Date_Of_Purchase,Price,Quantity) values ( '" + BId + "','" + BName + "','" + BAuthor + "'  , '" + BPublication + "' ,'" + BGenre + "', '" + DateofPurchase + "' , '" + BPrice + "' , '" + BQuantity + "')";
                    cmd1.ExecuteNonQuery();
                    con1.Close();


                    MessageBox.Show("Computer Added Successfully !", "Success", MessageBoxButtons.OK);
                    Bookid.Clear();
                    BookName.Clear();
                    AuthorName.Clear();
                    GenreName.Clear();
                    PublicationName.Clear();
                    BookPrice.Value = 0;
                    Bookquantity.Value = 0;

                   
                }

            }
            
           

               

        

        private void Cancelbookbtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Unsaved Data may be deleted ","Warning", MessageBoxButtons.OK, MessageBoxIcon.Question)== DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}

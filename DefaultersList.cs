using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ICSharpCode.SharpZipLib.Zip.ExtendedUnixData;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_Library
{
    public partial class DefaultersList : Form
    {
        public DefaultersList()
        {
            InitializeComponent();
        }

        private void DefaultersList_Load(object sender, EventArgs e)
        {
            label3.Visible = false; 
            label2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=STORMER-TECH\\SQLEXPRESS ; database=LibX; integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            
            cmd.CommandText = " Select * from IssueBooks where DueDate < '"+DateTime.Now.ToString()+"' and ReturnDate is null and Fine is null";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();

            cmd.CommandText = "Select * from IssueBooks  where DueDate < '"+DateTime.Today+"' and ReturnDate is null";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            label3.Visible = true; 
            label2.Visible = true;
            label2.ForeColor = Color.Blue;
            label2.Text = "Composing Mail....";



            int count = dataSet.Tables[0].Rows.Count;

            try
            {
                if (count == 0)
                {
                   
                    label2.ForeColor = Color.Red;
                    label2.Text = "No Defaulters to send mail!";
                }

                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        string registerNumber = dataSet.Tables[0].Rows[i][1].ToString();
                        string studentName = dataSet.Tables[0].Rows[i][2].ToString();
                        string eMail = dataSet.Tables[0].Rows[i][3].ToString();
                        string collegeName = "GCE Salem CSE Department";
                        string dueDate = dataSet.Tables[0].Rows[i][7].ToString();
                        string issueDate = dataSet.Tables[0].Rows[i][6].ToString();
                        string libraryContactEmail = "csedeptlibraryatgceslm@gmail.com";
                        string collegeLibraryName = "Department Library Of CSE, GCE, Salem - 11 ";





                        string to = eMail;
                        string subject = "Immediate Action Required: Overdue Library Book Return Notice";

                        string body = $"Subject: Reminder: Overdue Library Books\n\n" +
                        $"Dear {studentName},\n\n" +
                        $"Register Number : {registerNumber},\n\n" +
                        $"I hope this email finds you well. This is a friendly reminder from the Department Library of CSE regarding the book you borrowed on {issueDate}. According to our records, the due date for the book was {dueDate}, and as of today, the items have not been returned.\n\n" +
                        $"It is crucial for all students to adhere to the library's borrowing policies to ensure that resources are available for everyone. We kindly request that you return the overdue book at your earliest convenience to avoid any late fees or penalties.\n\n" +
                        $"If you have already returned the book, please accept our apologies for any inconvenience. In that case, we recommend checking with the library staff to reconcile any discrepancies in our records.\n\n" +
                        $"If, for any reason, you are unable to return the book promptly or have concerns, please do not hesitate to reach out to us at {libraryContactEmail} or visit the library in person. We are here to assist you and discuss possible solutions.\n\n" +
                        $"Thank you for your attention to this matter, and we appreciate your cooperation in maintaining the integrity of our library resources.\n\n" +
                        $"Best regards,\n\n" +
                        $"{collegeLibraryName}\n";


                        string from = "csedeptlibraryatgceslm@gmail.com";
                        string password = "frkk qknr xjgk alsf";
                        MailMessage mailMessage = new MailMessage(from, to);

                        mailMessage.Subject = subject;
                        mailMessage.Body = body;

                        SmtpClient smtp = new SmtpClient();
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;

                        System.Net.NetworkCredential nc = new System.Net.NetworkCredential(from, password);
                        smtp.Credentials = nc;
                        smtp.EnableSsl = true;


                        smtp.Send(mailMessage);


                        label2.ForeColor = Color.Green;
                        label2.Text = "Mail(s) sent successfully";

                        button1.Visible = true;

                    }




                }
            }
            catch (Exception ex)
            {

                label3.Visible = true;
                label2.ForeColor = Color.Red;
                label2.Text = "Can't Send the mail. Please connect to Internet";
                button1.Visible = true;

            }














           
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

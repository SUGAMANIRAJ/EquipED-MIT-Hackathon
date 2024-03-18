using HarfBuzzSharp;
using PdfSharpCore.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Forms;
using static IronPython.Modules._ast;
using static IronPython.Modules.PythonDateTime;
using static IronPython.Modules.PythonThread;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Media.Effects;
using System.Windows.Media.Media3D;

namespace Project_Library
{
    public partial class Notifyab : Form
    {
        public Notifyab()
        {
            InitializeComponent();
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

            cmd.CommandText = "Select * from Absent";

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
                    label2.Text = "No Absentees to send mail!";
                }

                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        string registerNumber = dataSet.Tables[0].Rows[i][1].ToString();
                        string studentName = dataSet.Tables[0].Rows[i][0].ToString();
                        string eMail = dataSet.Tables[0].Rows[i][5].ToString();
                        string collegeName = "GCE Salem CSE Department";
                        
                        string libraryContactEmail = "projectlab@gmail.com";
                        string collegeLibraryName = "IT Department Project Lab.MIT,Chrompet";
                        string to = eMail;
                        string subject = "Regarding Your Recent Absence from Laboratory Session";
                        string body = $"Subject: Notification of Absence from Laboratory Session\n\n" +
                        $"Dear {studentName},\n\n" +
                        $"Register Number : {registerNumber},\n\n" +
                      "I hope this email finds you well.I am writing to inform you about your absence from the laboratory.It has come to our attention that you were not present during the specified laboratory session."+"Participation in laboratory sessions is integral to your learning experience and is crucial for understanding the practical aspects of the course material.Your absence not only affects your own learning but also disrupts the flow of the session and may hinder the learning experience of your peers.\n\n"+

"If there were any unavoidable circumstances that prevented you from attending the laboratory session, please do not hesitate to communicate with us at your earliest convenience.We understand that unforeseen events can occur, and we are here to support you through any challenges you may face.\n\n" +

"However, consistent attendance and active participation are essential for your success in this course.I encourage you to make every effort to attend all future laboratory sessions to maximize your learning opportunities.\n\n" +

"Please feel free to reach out if you have any questions or concerns regarding your absence or any aspect of the course. We are here to assist you in any way we can.\n\n" +

"Thank you for your attention to this matter, and I look forward to your active participation in future laboratory sessions.\n\n" +

"Best regards,\n"+
"Mahendran M\n"+
"Laboratory Admin\n"+

"CollegeLab@gmail.com";


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



        private void Notifyab_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= STORMER-TECH\\SQLEXPRESS ; database=LibX ; Integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from Absent ";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);

            dataGridView1.DataSource = dataset.Tables[0];
            label2.Visible = false;
        }
    }
}

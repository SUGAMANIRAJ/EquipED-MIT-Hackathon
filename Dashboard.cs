using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Library.Properties;
using QuestPDF;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Library
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
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












        private void rgisterStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterStudent registerStudent = new RegisterStudent();
            registerStudent.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

          
            

        }

       

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AddBooks addBooks = new AddBooks();
            addBooks.Show();
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBooks editBooks = new EditBooks();
            editBooks.Show();
        }

        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudent manageStudents = new ManageStudent();   
            manageStudents.Show();
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBooks issuebooks = new IssueBooks();
            issuebooks.Show();
        }

        private void defaulterListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultersList defaultersList = new DefaultersList();
            defaultersList.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBooks returnBooks = new ReturnBooks();
            returnBooks.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to log out ", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            // Create a SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Set the default file name and extension
            saveFileDialog.FileName = "Demo.pdf";
            saveFileDialog.DefaultExt = "pdf";

            // Set the filter for the file extension
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";

            // Show the SaveFileDialog
            DialogResult result = saveFileDialog.ShowDialog();

            // If the user clicked OK in the dialog
            if (result == DialogResult.OK)
            {
                // Get the selected file name
                string filePath = saveFileDialog.FileName;

                // Generate PDF and save it to the selected file path
                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(2, Unit.Centimetre);
                        page.PageColor(Colors.White);
                        page.DefaultTextStyle(x => x.FontSize(20));

                        page.Header()
                            .Text("Hello From Rider!")
                            .SemiBold().FontSize(30).FontColor(Colors.Blue.Medium);

                        page.Content()
                            .PaddingVertical(1, Unit.Centimetre)
                            .Column(x =>
                            {
                                x.Spacing(20);
                                x.Item().Text(Placeholders.LoremIpsum());
                                x.Item().Image(Placeholders.Image(200, 100));
                            });

                        page.Footer()
                            .AlignCenter()
                            .Text(x =>
                            {
                                x.Span("Page ");
                                x.CurrentPageNumber();

                            });


                    });



                })
                 .GeneratePdf(filePath);


            }


            }

        private void label2_Click(object sender, EventArgs e)
        {

          AddBooks addBooks= new AddBooks();
            addBooks.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            EditBooks editBooks = new EditBooks();
            editBooks.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            RegisterStudent registerStudent = new RegisterStudent();
            registerStudent.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ManageStudent manageStudent = new ManageStudent();  
            manageStudent.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            All_Books books = new All_Books();  
            books.Show();   
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            all_students students = new all_students();
            students.Show();
        }

      
      

        private void menuStrip1_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void menuStrip1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_DragOver(object sender, DragEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.WindowState = FormWindowState.Minimized;
        
          }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

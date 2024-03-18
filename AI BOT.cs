using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Library
{
    public partial class AI_BOT : Form
    {
        public AI_BOT()
        {
            InitializeComponent();
           
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void RunPythonScript(string scriptPath)
        {
            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.CreateScope();

            engine.ExecuteFile("C:\\Safe\\Project Library\\Chatbot\\chatbotmodel.py", scope);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Replace 'path_to_your_script.py' with the path to your Python script
            RunPythonScript("C:\\Safe\\Project Library\\Chatbot\\chatbotmodel.py");
        }


        private void AI_BOT_Load(object sender, EventArgs e)
        {

        }
    }
}

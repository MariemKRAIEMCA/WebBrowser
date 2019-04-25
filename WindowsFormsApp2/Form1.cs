using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://github.com/login");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            HtmlDocument htmlDoc = webBrowser1.Document as HtmlDocument;
            Console.WriteLine(webBrowser1);
            htmlDoc.GetElementById("login_field").InnerText = "mariem.kraiem@ca-centreloire.com";
            
            var signeIn = htmlDoc.GetElementById("Sign in");
            
        }
    }
}

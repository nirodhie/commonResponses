using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;
using OutlookApp = Microsoft.Office.Interop.Outlook.Application;



namespace CommonResponses
{
    public partial class Form1 : Form
    {

        string ResponseName = "";
        string pathToResponses = @"c:\users\hclteska\responses\";
        public int responsesCount = Directory.GetFiles(@"c:\users\hclteska\responses\", "*.txt", SearchOption.TopDirectoryOnly).Length;
        

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "You have " +((responsesCount+1).ToString())+" files with responses" ;

           
            string[] fileNames = new DirectoryInfo(pathToResponses).GetFiles().Select(o => o.Name).ToArray();


            Point newLoc = new Point(5, 15);
            for (int i = 0; i< (responsesCount); i++)
            {
                RadioButton rdo = new RadioButton();
                rdo.Width = 150; //szerokość tekstu przy radiobuttonie
                rdo.Name = "RadioButton" + i;
                rdo.Text = Path.GetFileNameWithoutExtension(fileNames[i]);
                rdo.Location = newLoc;
                newLoc.Offset(0, 20);
                groupBox1.Controls.Add(rdo);

                rdo.Click += delegate
                {
                    textBox1.Text = File.ReadAllText(pathToResponses + rdo.Text + ".txt");  
                };
            }

            
        }


        protected void button_Click(object sender, EventArgs e)
        {
            RadioButton button = sender as RadioButton;
            textBox1.Text = button.Text;
            // identify which button was clicked and perform necessary actions
        }


        private void checkChanged(object sender, EventArgs e)
        {
            foreach (RadioButton rdo in groupBox1.Controls)
            {
                if (rdo.Checked)
                    textBox1.Text = rdo.Text;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            File.WriteAllText(pathToResponses + textBox2.Text + ".txt", textBox1.Text);
        }

       

        private void button3_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            ResponseName = btn.Text;
            textBox1.Text = File.ReadAllText(pathToResponses + ResponseName + ".txt");
            button1.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = ResponseName;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ResponseName = btn.Text;
            textBox1.Text = File.ReadAllText(pathToResponses + ResponseName + ".txt");
            button1.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = ResponseName;
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ResponseName = btn.Text;
            textBox1.Text = File.ReadAllText(pathToResponses + ResponseName + ".txt");
            button1.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = ResponseName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ResponseName = btn.Text;
            textBox1.Text = File.ReadAllText(pathToResponses + ResponseName + ".txt");
            button1.Visible = true;
            textBox2.Text = ResponseName;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ResponseName = btn.Text;
            textBox1.Text = File.ReadAllText(pathToResponses + ResponseName + ".txt");
            button1.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = ResponseName;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ResponseName = btn.Text;
            textBox1.Text = File.ReadAllText(pathToResponses + ResponseName + ".txt");
            button1.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = ResponseName;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

            OutlookApp outlookApp = new OutlookApp();
            MailItem mailItem = outlookApp.CreateItem(OlItemType.olMailItem);

            mailItem.Subject = ResponseName;
            mailItem.Body = textBox1.Text;
            mailItem.Display(true);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }


        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ResponseName = btn.Text;
            textBox1.Text = File.ReadAllText(pathToResponses + ResponseName + ".txt");
            button1.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = ResponseName;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ResponseName = btn.Text;
            textBox1.Text = File.ReadAllText(pathToResponses + ResponseName + ".txt");
            button1.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = ResponseName;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ResponseName = btn.Text;
            textBox1.Text = File.ReadAllText(pathToResponses + ResponseName + ".txt");
            button1.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = ResponseName;
        }
    }
}

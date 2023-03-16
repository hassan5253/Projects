using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Attendence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {            
            StreamWriter writer = new StreamWriter("D:\\Attendence.txt",true);
            writer.WriteLine(textBox1.Text +"\t"+DateTime.Now.ToString("HH:mm:ss")+"\tIN\t"+ DateTime.Now.ToString("ddMMMyyy"));
            writer.Flush();
            writer.Close();
            writer.Dispose();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("D:\\Attendence.txt", true);
            writer.WriteLine(textBox1.Text + "\t" + DateTime.Now.ToString("HH:mm:ss") + "\tOUT\t" + DateTime.Now.ToString("ddMMMyyy"));
            writer.Flush();
            writer.Close();
            writer.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_Stream
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.label1.Text = "File Location";
            this.label2.Text = "File Name";
            this.button1.Text = "File Stream Reader";
            this.textBox3.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            byte[] b = new byte[100];
            char[] ch = new char[100];
            FileStream fs = new FileStream(@"e:\iqra notes\file1.txt", FileMode.OpenOrCreate);
            fs.Read(b, 0, 100);
            Decoder d = Encoding.UTF8.GetDecoder();
            d.GetChars(b, 0, b.Length, ch, 0);
            foreach (char c in ch)
            {
                this.textBox3.Text += c;
            }
            
        }
    }
}

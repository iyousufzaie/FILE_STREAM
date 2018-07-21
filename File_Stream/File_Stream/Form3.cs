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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Stream writer";
            this.label1.Text = "File location";
            this.label2.Text = "File Name";
            this.button1.Text = "File Stream Writer";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] b = new byte[100];
            char[] ch = new char[100];
            string fn = textBox2.Text + textBox3.Text;
            FileStream fs = new FileStream(fn, FileMode.OpenOrCreate);
            ch = textBox1.Text.ToCharArray();
            Encoder en = Encoding.UTF8.GetEncoder();
            en.GetBytes(ch, 0, ch.Length, b, 0, true);
            fs.Write(b, 0, b.Length);
            MessageBox.Show("File has been Written");
            fs.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaShangin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK) ;
            var w = new Controller();
            w.writer(openFileDialog1.FileName, textBox1.Text);
            textBox1.Modified = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var r = new Controller();
                textBox1.Text = r.reader(openFileDialog1.FileName);
            }
        }
    }
}


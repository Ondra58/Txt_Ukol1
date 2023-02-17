using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog otevirac = new OpenFileDialog();
            if (otevirac.ShowDialog() == DialogResult.OK)
            {
                StreamReader ctenar = new StreamReader(otevirac.FileName, Encoding.GetEncoding("windows-1250"));
                listBox1.Items.Clear();
                while (!ctenar.EndOfStream)
                {
                    listBox1.Items.Add(ctenar.ReadLine());
                }
                ctenar.Close();

            }
            foreach (string line in listBox1.Items)
            {
                while (listBox1.Items.Contains(' '))
                {
                    foreach (string vstup in listBox1.Items)
                    {
                        if (vstup == "  ")
                        {
                            //vstup = vstup.Replace(" ", "");
                        }
                    }
                }


            }
        }
    }
}

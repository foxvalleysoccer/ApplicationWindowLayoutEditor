using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowSizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int count = 0;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            count = 0;
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.MainWindowTitle))
                {
                    listBox1.Items.Add(p.MainWindowTitle);
                    count++;
                    var handle = p.MainWindowHandle;
                    
                }
            }
            CountOfRunning_lbl.Text = count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1_SelectedIndexChanged(sender, e);
        }
    }
}

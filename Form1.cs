using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinCSCourse2023.Lab1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }
    }
}

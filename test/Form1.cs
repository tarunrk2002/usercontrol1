using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        UserControl2 u2 = new UserControl2();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void first_button_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(u2);
            u2.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void second_button_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_app1
{
    public partial class TrickyButton : Form
    {
        public TrickyButton()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Point point = new Point(350, 200);
            this.button1.Location = point;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shape shape = new Shape();
            Rectangle rect = new Rectangle();
            Shape shape2 = (Shape)rect;

            Shape shape3 = new Rectangle(); 

            string msg_area = shape3.Area();
            string msg_draw = shape3.Draw();

            MessageBox.Show(msg_area);
            MessageBox.Show(msg_draw);
        }
    }
}

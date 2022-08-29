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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void addStudentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void trickyButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrickyButton view = new TrickyButton();
            view.Show();
        }
    }
}

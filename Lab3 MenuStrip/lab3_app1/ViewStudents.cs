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
    public partial class ViewStudents : Form
    {
        Student[] students = new Student[3];
        public ViewStudents(Student[] students)
        {
            this.students = students;
            InitializeComponent();
        }


        private void ViewStudents_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.students;
        }
    }
}

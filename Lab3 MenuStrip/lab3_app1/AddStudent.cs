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
    public partial class AddStudent : Form
    {
        int index = 0;
        Student[] students = new Student[3];
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = textBox1.Text;
            student.Email = textBox2.Text;
            student.Address = textBox3.Text;
            this.students[index] = student;
            this.index++;
            MessageBox.Show("Student Inserted Success", "Success");
        }
    }
}


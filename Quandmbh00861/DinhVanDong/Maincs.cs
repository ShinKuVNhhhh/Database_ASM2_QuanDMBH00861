using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinhVanDong
{
    public partial class Maincs : Form
    {
        public Maincs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(); 
            form.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Departments form = new Departments();
            form.ShowDialog();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Course form = new Course();
            form.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructors form1 = new Instructors();
            form1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students form1 = new Students();
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Attendance_Records attendance_Records = new Attendance_Records();
            attendance_Records.ShowDialog();
            this.Hide();
        }
    }
}

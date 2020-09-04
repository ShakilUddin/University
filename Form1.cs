using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GradStudent gra = new GradStudent(1, "Shakil", "Uddin", "Dhanmondi", "Dhaka", 420, 80, 60);
            ArrayList alist = new ArrayList();
            alist.Add(50);
            alist.Add(80);
            alist.Add(gra);
            
            gra.PrintGrade(alist);
            
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace University
{
    class GradStudent : FullTimeStudent
    {
        
        int id;

        public int Id { get => id; set => id = value; }
    
        public GradStudent(int id, string fname, string lname, string stradrs, string town, int tel, int t1, int t2)
            : base(fname, lname, stradrs, town, tel, t1, t2)
        {
            this.id = id;
        }

        public GradStudent()
        {

        }

        public void PrintGrade(ArrayList Alist)
        {
          for(int i = 0; i < Alist.Count; i++)
            {
                if(Alist[i] is GradStudent)
                {
                    GradStudent gra = (GradStudent)Alist[i];
                    MessageBox.Show("Grade is " + gra.ComputeGrade());
                }
            }
        }

     

    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace University
{
    class PartTimeStudent : FullTimeStudent
    {
        int ssnum;
        public int Ssnum { get => ssnum; set => ssnum = value; }

        public PartTimeStudent(int snum, string fname, string lname, string stradrs, string town, int tel, int t1, int t2)
            : base(fname, lname, stradrs, town, tel, t1, t2)
        {
            this.ssnum = snum;
        }

        public PartTimeStudent()
        {

        }

        override public string ComputeGrade()
        {
            double total = (0.45 * Test1) + (0.60 * Test2);
            string grade = "";

            if (total > 90)
            {
                grade = "A";
            }
            else if (total > 80)
            {
                grade = "B";
            }
            else if (total > 70)
            {
                grade = "C";
            }
            else if (total > 60)
            {
                grade = "B";
            }
            else if (total > 50)
            {
                grade = "C";
            }
            else if (total > 40)
            {
                grade = "D";
            }
            else if (total > 30)
            {
                grade = "E";
            }
            else
            {
                grade = "Fail";
            }

            return grade;
        }

    }
}

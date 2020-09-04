using System;
using System.Collections.Generic;
using System.Text;

namespace University
{
    class UnderGradStudent : GradStudent
    {
        public UnderGradStudent(int id, string fname, string lname, string stradrs, string town, int tel, int t1, int t2)
            : base(id, fname, lname, stradrs, town, tel, t1, t2)
        { 
        }

        public UnderGradStudent()
        {

        }

        
    }
}

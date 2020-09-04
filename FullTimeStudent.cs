namespace University
{
    abstract class FullTimeStudent
    {
        protected private string firstname;
        protected private string lastname;
        protected private string streetaddress;
        protected private string city;
        protected private int telephone;
        protected private int test1;
        protected private int test2;

        protected string Firstname { get => firstname; set => firstname = value; }
        protected string Lastname { get => lastname; set => lastname = value; }
        protected string Streetaddress { get => streetaddress; set => streetaddress = value; }
        protected string City { get => city; set => city = value; }
        protected int Telephone { get => telephone; set => telephone = value; }
        protected int Test1 { get => test1; set => test1 = value; }
        protected int Test2 { get => test2; set => test2 = value; }

        public FullTimeStudent(string fname, string lname, string stradrs, string town, int tel, int t1, int t2)
        {
            firstname = fname;
            lastname = lname;
            streetaddress = stradrs;
            city = town;
            telephone = tel;
            test1 = t1;
            test2 = t2;
        }

        public FullTimeStudent()
        {

        }

        virtual public string ComputeGrade()
        {
            double total = (0.45 * Test1) + (0.55 * Test2);
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

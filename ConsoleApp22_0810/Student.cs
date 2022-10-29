using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22_0810
{
    public class Student
    {
        protected int aa;
        internal int bb;
        protected internal int cc;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string School { get; set; }

        public Student()
        {

        }

        public Student(int id, string name, string sex, string school)
        {
            this.Id = id;
            this.Name = name;
            this.Sex = sex;
            this.School = school;
        }
    }
}

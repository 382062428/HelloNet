using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22_0810
{
    public class BigStudent:Student
    {
        public string Major { get; set; }
        public string Group { get; set; }
        public BigStudent():base()
        {

        }

        public BigStudent(int id, string name, string sex, string school, string major, string group)
            : base(id, name, sex, school)
        {
            this.Major = major;
            this.Group = group;
            base.Name = "大明";
            base.aa = 100;
        }
    }
}

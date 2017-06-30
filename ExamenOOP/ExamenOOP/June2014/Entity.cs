using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOOP.June2014
{
    class Entity
    {
    }

    public class Student
    {
        private string name;

        public Student(string name)
        {
            this.name = name;
        }

        public virtual string toString()
        {
            return this.name;
        }
    }

    public class StudentWithScholarship : Student
    {
        private int scolarship;

        public StudentWithScholarship(string name,int scolarship) : base(name)
        {
            this.scolarship = scolarship;
        }

        public override string toString()
        {
            return base.toString() + " " + this.scolarship;
        }
    }
}

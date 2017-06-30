using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOOP.June2016
{
    public class Student
    {
        private string name;
        private string city;

        public Student(string name, string city)
        {
            if (string.IsNullOrEmpty(city) || string.IsNullOrEmpty(name))
            {
                throw new Exception("name/city cannot be null or empty");
            }
            this.name = name;
            this.city = city;
        }
        

        public string getCity()
        {
            return this.city;
        }

        public string getName()
        {
            return this.name;
        }

        public virtual string toString()
        {
            return this.name + " " + this.city;
        }
    }

    public class StudentWithScholarship:Student
    {
        private int scholarship;

        public StudentWithScholarship(string name,string city,int scholarship) : base(name, city)
        {
            if (!(scholarship > 0))
            {
                throw new Exception("scholarship must be > 0");
            }
            this.scholarship = scholarship;
        }

        public override string toString()
        {
            return base.toString() + " " + this.scholarship;
        }
    }
}

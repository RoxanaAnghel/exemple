using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOOP.September2016
{
    public abstract class  Entity
    {
        private string city;

        public Entity(string city)
        {
            if (string.IsNullOrEmpty(city))
            {
                throw new Exception("string cannot be null/empty");
            }
            this.city = city;
        }

        public string getCity()
        {
            return this.city;
        }

        public abstract int amountRecived();

        public virtual string toString()
        {
            return this.city;
        }

    }

    public class Student:Entity
    {
        private int scholarship;

        public Student(string city,int scholarship):base(city)
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

        public override int amountRecived()
        {
            return this.scholarship;
        }
    }

    public class Professor:Entity
    {
        private int salary;

        public Professor(string city,int salary) : base(city)
        {
            if (!(salary > 0))
            {
                throw new Exception("salary must be > 0");
            }
            this.salary = salary;
        }

        public override int amountRecived()
        {
            return this.salary;
        }

        public override string toString()
        {
            return base.toString() + " " + salary;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOOP.June2014
{
    public class J2014
    {
        public void Run()
        {
            Dictionary<string, Student> students = CreateMap();

            string text = Console.ReadLine();

            if (students.ContainsKey(text))
            {
                Console.WriteLine(students[text].toString());
            }
            else
            {
                Console.WriteLine("Not found");
            }

            Console.WriteLine(ContainsNameWithChar(students, text[0]));

        }

        public bool ContainsNameWithChar(Dictionary<string, Student> students,char c)
        {

            for(int i = 0; i < students.Count; i++)
            {
                string name = students.ElementAt(i).Key;
                if (name[0] == c)
                {
                    return true;
                }
            }

            return false;
        }

        public Dictionary<string, Student> CreateMap()
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            Student s1 = new Student("Ionescu");
            StudentWithScholarship s2 = new StudentWithScholarship("Popescu", 200);
            students.Add("Ionescu", s1);
            students.Add("Popescu", s2);
            return students;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOOP.June2016
{
    public class J2016
    {


        /*
         * List<T> : Add(T t): adds t at the end of the list
         *           Insert(int i,T t) inserts t at index i in the list
         * Dictionary<K,V> : Add(K k,T t) adds the pair <k,t> to the dictionary
         *                   Contains(K k) return true if it contains the K k , false otherwise
         *                   Element(i) returns the pair <K,T> that is at position i
         *                   <K,V>.Key returns k .Value returns v
         */

        public void RunJ2016()
        {
            List<Student> students = new List<Student>();
            Student s1 = new Student("Ioana", "Arad");
            Student s2 = new StudentWithScholarship("Daniel", "Oradea", 100);
            Student s3 = new StudentWithScholarship("Costel", "Arad", 100);
            Student s4 = new StudentWithScholarship("Gigel", "Oradea", 100);
            Insert(students,s1);
            Insert(students,s2);
            Insert(students,s3);
            Insert(students,s4);

            PrintList(students);
            PrintByCity(students);
        }

        public bool IsGraterByName(Student s1, Student s2)
        {
            if(string.Compare(s1.getName(),s2.getName()) > 0)
            {
                return true;
            }
            return false;
        }


        public void PrintByCity(List<Student> s)
        {
            Dictionary<string, List<Student>> cityStudentMap = new Dictionary<string, List<Student>>();

            for(int i = 0; i < s.Count; i++)
            {
                if (cityStudentMap.ContainsKey(s[i].getCity()))
                {
                    Insert(cityStudentMap[s[i].getCity()], s[i]);
                }
                else
                {
                    cityStudentMap.Add(s[i].getCity(), new List<Student>());
                    Insert(cityStudentMap[s[i].getCity()], s[i]);
                }
            }

            for(int i = 0; i < cityStudentMap.Count; i++)
            {
                string city = cityStudentMap.ElementAt(i).Key;
                List<Student> st = cityStudentMap.ElementAt(i).Value;
                Console.WriteLine("city: " + city);
                Console.WriteLine("Stundets: ");
                for(int j = 0; j < st.Count;j++)
                {
                    Console.WriteLine(st[j].getName());
                }
            } 

        }

        public void PrintList(List<Student> s)
        {
            for(int i = 0; i < s.Count; i++)
            {
                Console.WriteLine(s[i].toString());
            }
        }

        public void Insert(List<Student> sl,Student s)
        {
            int size = sl.Count;
            if (size == 0){
                sl.Add(s);
            }
            else if (size == 1)
            {
                if (IsGraterByName(s, sl[0]))
                {
                    sl.Add(s);
                }
                else
                {
                    sl.Insert(0, s);
                }
            }
            else if (IsGraterByName(s, sl[size - 1]))
            {
                sl.Add(s);
            }
            else if (IsGraterByName(sl[0], s))
            {
                sl.Insert(0, s);
            }
            else
            {
                for (int i = 0; i < size - 1; i++)
                {
                    if (IsGraterByName(s, sl[i]) && IsGraterByName(sl[i + 1], s))
                    {
                        sl.Insert(i + 1, s);
                    }
                }
            }
            
        }

    }

    
}

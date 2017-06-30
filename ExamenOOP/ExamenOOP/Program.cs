using ExamenOOP.June2014;
using ExamenOOP.June2015;
using ExamenOOP.June2016;
using ExamenOOP.September2015;
using ExamenOOP.September2016;
using System;

namespace ExamenOOP
{
    class Program
    {
        static void RunSeptember2016()
        {
            //Entity e1 = new Student("34", 34);
            //if (e1.GetType() == typeof(Student))
            //{
            //    Console.WriteLine("is student");
            //}
            S2016 s2016 = new S2016();
            s2016.Run();
        }

        static void RunJune2016()
        {
            J2016 j2016 = new J2016();
            j2016.RunJ2016();
        }

        static void RunSeptember2015()
        {
            S2015 s2015 = new S2015();
            s2015.Run();
        }


        static void RunJune2015()
        {
            J2015 j2015 = new J2015();
            j2015.Run();
        }

        static void RunJune2014()
        {
            J2014 j2014 = new J2014();
            j2014.Run();
        }

        static void Main(string[] args)
        {
            //RunJune2016();
            //RunSeptember2015();
            //RunJune2015();
            RunJune2014();
        }
    }
}

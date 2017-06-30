using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOOP.September2016
{
    public class S2016
    {

        /*
         *  requirements : http://www.cs.ubbcluj.ro/wp-content/uploads/subiect_licenta_informatica_septembrie_2016_en.pdf
         *  List<T> list
         *  list[i] returns the item T that is located at index i in the list
         *  Add(i) adds the item i at the end of the list
         *  Count returns the number of elements in the list
         *  indexing starts at 0 so we can acces elements until index Count-1 
         */

        public void Run()
        {
            List<Entity> entities = CreateEntitiesList();
            RearangeList(entities);

            Console.WriteLine("Enter city: ");
            string city = Console.ReadLine();
            int amount = AmountByCity(city, entities);
            Console.WriteLine("The amount is " + amount);

        }


        public int AmountByCity(string city, List<Entity> entities)
        {
            int total = 0;
            for(int i = 0; i < entities.Count; i++)
            {
                if (string.Compare(city, entities[i].getCity()) == 0)
                {
                    total = total + entities[i].amountRecived();
                }
            }
            return total;
        }


        public void RearangeList(List<Entity> list)
        {
            int size = list.Count;

            for(int i = 0; i < size-1; i++)
            {
                for(int j = i; j < size; j++)
                {

                    if(list[i].GetType()==typeof(Student) && list[j].GetType() == typeof(Professor))
                    {
                        Entity aux = list[i];
                        list[i] = list[j];
                        list[j] = aux;
                    }
                    else if((list[i].GetType()== typeof(Professor) && list[j].GetType()==typeof(Professor))
                        && list[i].amountRecived()< list[j].amountRecived())
                    {
                        Entity aux = list[i];
                        list[i] = list[j];
                        list[j] = list[i];
                    }
                    else if((list[i].GetType()==typeof(Student) && list[j].GetType()==typeof(Student))
                        && list[i].amountRecived() > list[j].amountRecived())
                    {
                        Entity aux = list[i];
                        list[i] = list[j];
                        list[j] = list[i];
                    }
                }
            }
        }


        /*
         * (b) Defines a function that creates and returns a list of four Entities,
         *  two Students and two Professors.
         */
        public List<Entity> CreateEntitiesList()
        {
            List<Entity> entities = new List<Entity>();

            Entity e1 = new Student("student1city", 10);
            Entity e2 = new Student("student2city", 110);

            Entity e3 = new Professor("cluj", 1000);
            Entity e4 = new Professor("cluj", 101055555);

            entities.Add(e1);
            entities.Add(e4);
            entities.Add(e3);
            entities.Add(e2);

            return entities;
        }
    }
}

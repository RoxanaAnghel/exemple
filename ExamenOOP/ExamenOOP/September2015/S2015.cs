using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOOP.September2015
{
    public class S2015
    {
        public void Run()
        {
            List<Medicine> list = CreateList();

            SortList(list, 70);

            Delete(list);

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].sellingPrice());
            }
        }


        public void Delete(List<Medicine> ml)
        {
            for(int i = 0; i < ml.Count; i++)
            {
                if (ml[i].sellingPrice() < 40)
                {
                    ml.RemoveAt(i);
                }
            }
        }

        public void SortList(List<Medicine> ml,int v)
        {
            int size = ml.Count;

            for(int i = 0; i < size - 1; i++)
            {
                int currentPrice = ml[i].sellingPrice();
                for (int j = i + 1; j < size; j++)
                {
                    if (currentPrice > v)
                    {
                        if(currentPrice> ml[j].sellingPrice() && ml[j].sellingPrice() > v)
                        {
                            Medicine aux = ml[i];
                            ml[i] = ml[j];
                            ml[j] = aux;
                        }
                    }
                }

                
            }

        }

        public List<Medicine> CreateList()
        {
            List<Medicine> ml = new List<Medicine>();

            Medicine m1 = new Medicine(100);
            Medicine m2 = new CompensatedMedicine(70,0.05);
            Medicine m3 = new CompensatedMedicine(90,0.8);

            ml.Add(m1);
            ml.Add(m2);
            ml.Add(m3);

            return ml;
        }
    }
}

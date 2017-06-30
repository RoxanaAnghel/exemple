using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOOP.June2013
{
    class Entity
    {
    }

    public class Product
    {
        private string name;

        public Product(string name)
        {
            this.name = name;
        }

        public virtual void Print()
        {
            Console.WriteLine(this.name);
        }
    }

    public class AlterableProduct:Product
    {
        private int validity;

        public AlterableProduct(string name,int validity) : base(name)
        {
            this.validity = validity;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(validity);
        }

    }

}

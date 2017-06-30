using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOOP.September2015
{
    class Entity
    {
    }

    public class Medicine
    {
        private int price;

        public Medicine(int price)
        {
            this.price = price;
        }

        public virtual int sellingPrice()
        {
            return this.price;
        }
    }

    public class CompensatedMedicine : Medicine
    {
        private double compensatedProcentage;

        public CompensatedMedicine(int price,double compensatedProcentage) : base(price)
        {
            this.compensatedProcentage = compensatedProcentage;
        }

        public override int sellingPrice()
        {
            return base.sellingPrice();
        }
    }
}

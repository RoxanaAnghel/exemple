using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOOP.June2015
{
    class Entity
    {
    }

    public class Product
    {
        private int price;

        public Product(int price)
        {
            this.price = price;
        }

        public virtual int sellingPrice()
        {
            return this.price;
        }
    }

    public class PackagedPrduct : Product
    {
        private int packagePrice;

        public PackagedPrduct(int price,int packagePrice) : base(price)
        {
            this.packagePrice = packagePrice;
        }

        public override int sellingPrice()
        {
            return base.sellingPrice() + this.packagePrice;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOOP.June2015
{
    public class J2015
    {
        public void Run()
        {
            List<Product> products = CreateList();
            for(int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i].sellingPrice());
            }

            Console.WriteLine("the avareage is = " + Avarage(products));

        }

        public double Avarage(List<Product> products)
        {
            double total = 0;
            for(int i = 0; i < products.Count; i++)
            {
                total = total + products[i].sellingPrice();
            }
            return total / products.Count;
        }

        public List<Product> CreateList()
        {
            List<Product> products = new List<Product>();

            Product p1 = new Product(100);
            Product p2 = new PackagedPrduct(70, 10);
            Product p3 = new PackagedPrduct(90, 15);

            Insert(products, p1);
            Insert(products, p2);
            Insert(products, p3);

            return products;

        }

        public bool IsGrater(Product p1,Product p2)
        {
            if (p1.sellingPrice() > p2.sellingPrice())
            {
                return true;
            }
            return false;
        }

        public void Insert(List<Product> products,Product product)
        {
            int price = product.sellingPrice();

            if (products.Count == 0)
            {
                products.Add(product);
            }
            else if (IsGrater( product, products[0]))
            {
                products.Insert(0, product);
            }
            else if (IsGrater(products[products.Count - 1], product))
            {
                products.Add(product);
            }
            else
            {
                for (int i = 0; i < products.Count - 1; i++)
                {
                    if (IsGrater(products[i], product) && IsGrater(product, products[i]))
                    {
                        products.Insert(i + 1, product);
                    }
                }
            }
            
        }
    }
}

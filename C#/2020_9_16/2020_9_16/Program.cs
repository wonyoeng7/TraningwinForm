using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    static int ArraySortPrice(Product T1, Product T2)
    {
        return T1.Price.CompareTo(T2.Price) * -1;
    }

    static int ArraySortName(Product T1, Product T2)
    {
        return T1.Name.CompareTo(T2.Name);
    }

    static void Main(string[] args)
    {
     

        List<Product> products = new List<Product>()
        {
            new Product() { Name = "감자", Price = 500 },
            new Product() { Name = "사과", Price = 700 },
            new Product() { Name = "고구마", Price = 400 },
            new Product() { Name = "배추", Price = 600 },
            new Product() { Name = "상추", Price = 300 }
        };

        //products.Sort(ArraySortPrice);
        //products.Sort(delegate (Product T1, Product T2) { return T1.Price.CompareTo(T2.Price); });//무명 delegate라고 한다.
        products.Sort((T1,T2)=> { return T1.Price.CompareTo(T2.Price); });  //람다식이라고 한다.
        foreach (var Temp in products)
        {
            Console.WriteLine(Temp.Name + "\t" + Temp.Price);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8_assignmnt
{
    class Product
    {
        public int Id;
        public string Name;
        public int Price;
        public string Brand;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] product = new Product[]
        {
                    new Product() { Id = 100, Name ="shoe", Price =30, Brand="adidas"},
                    new Product() { Id = 101, Name ="clothes",Price=1000, Brand="nike"},
                    new Product() { Id = 103, Name ="shirts",Price=100, Brand="raymond"},
                    new Product() { Id = 105, Name ="pen",Price=10, Brand="Cello"},
                    new Product() { Id = 107, Name ="watch",Price=2000, Brand="Fastrack"}
                  };
            
            //price is >500 using FORLOOP

            for (int i = 0; i < product.Length; i++)
            {
                if (product[i].Price >= 500)
                    Console.WriteLine($"name={product[i].Name},Brand={product[i].Brand}");

            }
            
            //price is >500 using FOREACH LOOP
            foreach (var e in product)
            {
                if (e.Price >= 500)
                    Console.WriteLine($"Name={e.Name},Brand{e.Brand}");
            }
            
            //price is >500 using LAMBDA EXPRESSION
            product.ToList().Where(e => e.Price >= 500).ToList().ForEach(e => Console.WriteLine($"Name={e.Name},Brand={e.Brand}"));

            
            //price is >500 using LINQ QUERY
            var result = from e in product
                         where e.Price >= 500
                         select e;
            result.ToList().ForEach(e => Console.WriteLine($"Name={e.Name}, Brand={e.Brand}"));
            Console.ReadLine();
        }
    }
}
        
    


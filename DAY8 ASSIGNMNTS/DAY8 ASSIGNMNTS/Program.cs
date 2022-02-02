using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8_ASSIGNMNTS
{
    class food
    {
        public int price;
        public string name;
        public int quantity;
        internal class ToList { }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {


            List<food> food = new List<food>()


            {
            new food() { name = "french fries", price = 50, quantity = 2 },
            new food() { name = "burger", price = 100, quantity = 3 },
            new food() { name = "chicken burger", price = 50, quantity = 6 },
            new food() { name = "pizza", price = 100, quantity = 2 },
            };

            // using FORLOOP

            for (int p = 0; food.Count > 0; p++)

            {
                if (food.Count > 1)
                    Console.WriteLine($"p={food[p]},name={food[p].name}");
            };

            // using FOREACH LOOP
            foreach (var p in food)
            {
                if (food.Count > 1)

                    Console.WriteLine($"quantity={p.quantity},name={p.name}");
            }

            // using LAMBDA EXPRESSION
            food.ToList().ForEach(p => Console.WriteLine($"quantity={p.quantity},name={p.name}"));

            // create employees using LINQ QUERY
            var result = from p in food
                         select p;
            result.ToList().ForEach(p => Console.WriteLine($"quantity={p.quantity},name={p.name}"));
            Console.ReadLine();
        }
    }


}








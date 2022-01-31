using System ;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6_morning_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
             ArrayList data = new ArrayList();
            int sum = 0;
            data.Add(35);
            data.Add(775);
            data.Add(90);
            foreach(var d in data)
            {
                sum = sum + (int)d;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}

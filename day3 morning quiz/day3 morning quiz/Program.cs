using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_morning_quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int score = 0, ans;
            string name;

        Console.WriteLine("enter your name:");
            name = Console.ReadLine();


            Console.WriteLine("***************************************************");
            Console.WriteLine("hi {0} , welcome to quiz by lokesh", name);
            Console.WriteLine("****************************************************");




            Console.WriteLine("Q1.who is chiranjeevi");
                Console.WriteLine("1.Actor 2.dancer 3.fighter 4.comidian");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if(ans==1)
            score += 20;
            Console.ReadLine();



            Console.WriteLine("Q2.who is MS.DHONI");
            Console.WriteLine("1.Actor 2.dancer 3.Crickter 4.comidian");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 3)
                score += 20;
            Console.ReadLine();


             Console.WriteLine("Q3.who is father of nation");
            Console.WriteLine("1.gandhi 2.subhash chandrabose 3.jawaharlal nehru 4.sardar");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if(ans==1)
            score += 20;
            Console.ReadLine();
        
             Console.WriteLine("Q4 .who is our cheif minister");
            Console.WriteLine("1.jagan 2.chandra babu 3.kalyan 4.none");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if(ans==1)
            score += 20;
            Console.ReadLine();


    }


}
    }


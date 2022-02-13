
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15project12
{
    internal class Program
{
    static void Main(string[] args)
    {
        StreamWriter sw = new StreamWriter("D:\\nadella\\file assignments programs\\file\\quiz\\lokesh quiz");
        int score = 0, ans;
        string name;
        Console.WriteLine("Enter your name");
        name = Console.ReadLine();
        Console.WriteLine("******************");
        Console.WriteLine("Hi{0},Welcome to quiz by lokesh", name);
        Console.WriteLine("******************");
        sw.WriteLine(name);
        Console.WriteLine("Q1.who is cm of Andhra pradesh:");
        Console.WriteLine("1.chandrababu naidu 2.jagan mohan reddy  3.pawankalyan  4.lokesh");
        ans = Convert.ToInt32(Console.ReadLine());
        if (ans == 2)
            score += 20;

        Console.WriteLine("Q2.Who is lokesh");
        Console.WriteLine("1.student   2.engineer  3.good boy   4.software trainee");
        ans = Convert.ToInt32(Console.ReadLine());
        if (ans == 4)
            score += 20;


        Console.WriteLine("Q3.Who is shiva");
        Console.WriteLine("1.student  2.enginner 3.bad boy 4.software trainee");
        ans = Convert.ToInt32(Console.ReadLine());
        if (ans == 4)
            score += 20;

        Console.WriteLine("Q4.What is the fullform of OTC:");
        Console.WriteLine("1.On The Company  2.Over The Counter  3.Over The Company  4.On The Count");
        ans = Convert.ToInt32(Console.ReadLine());
        if (ans == 2)
            score += 20;


        Console.WriteLine("Q5.Where is the headquarters of NB");
        Console.WriteLine("1.Florida  2.France  3.America  4.India");
        ans = Convert.ToInt32(Console.ReadLine());
        if (ans == 1)
            score += 20;
        sw.WriteLine(score);
        sw.Close();
        Console.WriteLine("******************");
        Console.WriteLine("Thank you for taking test, Admin will inform your result");


        Console.ReadLine();



    }
}
}

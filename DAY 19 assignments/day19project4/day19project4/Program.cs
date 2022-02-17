using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace day19project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ID Number: ");
            int input = Convert.ToInt32(Console.ReadLine());


            XmlDocument file = new XmlDocument();
            file.Load("D:\\nadella\\DAY 19 assignments\\Employee.xml");


            foreach (XmlNode node in file.DocumentElement.ChildNodes)
            {
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    bool id = node2.Name == "id";
                    bool isIndex = (id == true ? Convert.ToInt32(node2.InnerText) : 0) == input;
                    if (id && isIndex)
                    {
                        Console.WriteLine($"The Name of the ID is {node2.NextSibling.InnerText}.");
                    }
                }
            }
            Console.ReadLine();


        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace day19project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\nadella\\DAY 19 assignments\\Employee.XML");

            // XmlNode node = doc.DocumentElement.SelectSingleNode("/Employees/Employee");

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string text = node.InnerText; //or loop through its children as well

                Console.WriteLine(text);
            }

            Console.ReadLine();
        }
    }
}

           
        


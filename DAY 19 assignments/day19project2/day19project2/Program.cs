﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace day19project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\nadella\\DAY 19 assignments\\Employee.Xml");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach (XmlNode cnode in node.ChildNodes)
                {
                    if (cnode.Name == "Name")
                    {
                        Console.WriteLine(cnode.InnerText);
                    }
                }

            }
            Console.ReadLine();
        }
    }
}

        
    


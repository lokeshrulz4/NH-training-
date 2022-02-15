using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lokeshlibrary;

namespace publiclibrary
{
    public class MYDerivedClass : MyBaseClass
    {
        public void MyDerivedClassMethod()
        {
            int a = 10;
            // b = 20;
            c = 20;
            //d = 40;
            e = 60;
        }
    }
    public class MyOtherClass
    {
        public void MyOtherClassmethod()
        {
            MYDerivedClass mb = new MYDerivedClass();
            mb.a = 10;
            //mb.b = 20;
            //mb.c = 20;
            //mb.d = 40;
            //mb.e = 60;
        }
    }      
}


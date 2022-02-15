using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lokeshlibrary
{
    public class MyBaseClass
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        protected internal int e;



        public void MyBaseClassMethod()
        {
            a = 10;
            b = 20;
            c = 20;
            d = 40;
            e = 60;
        }
    }


    public class MyDerivedClass : MyBaseClass
    {
        public void MyDerivedClassMethod()
        {
            int a = 10;
           // b = 20;
            c = 20;
            d = 40;
            e = 60;
        }
    }


    public class MyOtherClass
    {
        public void MyOtherClassMethod()
        {
            MyBaseClass mb = new MyBaseClass();
            mb.a = 10;
            //mb.b = 20;
            //mb.c = 20;
            mb.d = 40;
            mb.e = 60;
        }
        
    }
}
            



    
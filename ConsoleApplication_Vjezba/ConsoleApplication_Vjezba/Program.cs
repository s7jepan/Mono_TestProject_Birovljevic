using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Vjezba
{
    class myBase
    {
        //base constructors
        public myBase()
        {
            Console.WriteLine("Konstruktor Base klase");

        }
        //base overloaded consturctor
        public myBase(string x)
        {
            Console.WriteLine("Overloadni Konstruktor Base klase");

        }
        //virtual function  
        public virtual void VirtualMethod()
        {
            Console.WriteLine("virtual method defined in the base class");
        }
    }

    class myDerived : myBase
    {
        //derived consturctor
        //public myDerived() : base()
        //{
        //    Console.WriteLine("Konstruktor Derived klase");

        //}
        // hiding the implementation of base class method  
        //overloaded derived constructor
        public myDerived()
        {
            Console.WriteLine("Konstruktor Derived klase");
        }
        public new void VirtualMethod()
        {
            Console.WriteLine("virtual method defined in the Derive class");

            //still access the base class method  
            base.VirtualMethod();
        }
    }
    class Grandchild : myDerived
    {
        public Grandchild()
        {
            Console.WriteLine("Konstruktor Grandchild-a");
        }
        public new void VirtualMethod()
        {
            Console.WriteLine("virtual method defined in the Grandchild class");

            //still access the base class method  
            base.VirtualMethod();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // class instance  
            new myDerived().VirtualMethod();
            Console.ReadKey();

            Console.WriteLine("/n Slijedi ispis iz Grandchild-a");
            new Grandchild().VirtualMethod();
            Console.ReadKey();

        }
    }
}

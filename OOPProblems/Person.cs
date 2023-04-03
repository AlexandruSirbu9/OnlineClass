using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProblems
{
     class Person
    {
         int age;
        public void Greet()
        {
            Console.WriteLine("Heloo!");
        }

        public int Age
        {
            get;set;
        }

        protected void SetAge(int age)
        {
            this.age = age;
        }
        public virtual void GataDePredat()
        {
            Console.WriteLine("Incepem sa predam!");
        }


    }
}

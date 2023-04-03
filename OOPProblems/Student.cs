using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProblems
{
    class Student : Person
    {
        public void GoToClases()
        {
            Console.WriteLine("I'm going to class!");
        }
        public void AfisareVarsta(int age)
        {
            Console.WriteLine("Varsta mea este : {0} de ani" , age);
        }

        public  override void  GataDePredat()
        {
            Console.WriteLine();
        }
    }
}

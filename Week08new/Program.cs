using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week08new
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("^_^_^_^_^_^_^\n");
            Console.WriteLine();

            Person person = new Person("Matthew",24);
            person.Talks();
        }
    }
}

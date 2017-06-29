using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week08new
{
    /// <summary>
    /// Person class for Tom's demo :^)
    /// </summary>
    class Person
    {
        //Private Instance Variables. or Fields

        private string _name;
        private int _age;
        //Public properties
        public string Name {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
                }
        public int Age {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }

        //Constructor

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        //Public Methods


        /// <summary>
        /// This following method will enable people to talk.
        /// </summary>

        public void Talks()
        {
            Console.WriteLine(this._name + " is talking!");
        }

    }
}

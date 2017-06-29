using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week08new
{

    class Student : Person
    {
        //Instance Vatiables, or strings
        private string _studentID;

        public string studentID
        {
            get
            {
                return this._studentID;
            }

            set
            {
                this._studentID = value;
            }
        }

        //Need a constructor to fix intital error for inheritance
        public Student(string name, int age, string studentID)
            :base (name, age)
        {
            
        }
    }
}

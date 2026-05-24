using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Student : Person
    {
        private string[] _subjects;

        //TODO: 2, add constructor
        public Student( string? _name, string[] _subjects) : base(_name)
        {
            Subjects = _subjects;
        }

        public string[] Subjects
        {
            get
            {   
                return _subjects;
            }

            set
            {
                 _subjects = value;
            }
        }
        
        //TODO: 3, print details to console
        public override void PrintDetails()
        {
            Console.WriteLine( $"Hi my name is {Name} and I am studying {string.Join(',', Subjects)}");
        }

    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Teacher : Person
    {

        private string _faculty;

        //TODO: 4, add constructor
        public Teacher(string _name, string _faculty) : base(_name)
        {
          Faculty = _faculty;
        }

        public string Faculty
        {
            get
            {
                return _faculty;
            }
            set
            {
                _faculty = value;
            }
        }

        public override void PrintDetails()
        {
            //TODO: 5, print details to console
           Console.WriteLine ($"Hi my name is {Name} and I teach in the {Faculty} faculty");
        
        }
      
    }
}

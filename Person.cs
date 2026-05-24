using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task3
{
    public abstract class Person
    {

        protected string _name;
        public Person()
         {

         }  

        public Person(string _name)
         {
              //TODO: 1, initialise _name field
                Name =_name;
         }

        public string Name
         {
            get {  return _name; }
            set { _name= value; }
         }

        public abstract void PrintDetails();

    }

}
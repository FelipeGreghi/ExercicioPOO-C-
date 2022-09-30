using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class Department
    {
        //Auto Properties
        public string Name { get; set; }

        //Constructors
        public Department()
        {

        }
        public Department(string name)
        {
            Name = name;
        }
    }
}

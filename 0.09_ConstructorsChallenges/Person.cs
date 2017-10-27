using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_ConstructorsChallenges
{
    class Person
    {
        public Person(string name, MobilePhone phone)
        {
            this.Name = name;
            this.Phone = phone;
        }

        public string Name { get; set; }
        public MobilePhone Phone { get; set; }
    }
}

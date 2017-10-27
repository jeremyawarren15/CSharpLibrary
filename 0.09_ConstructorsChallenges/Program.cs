using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_ConstructorsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bronze Challenge
            MobilePhone myPhone = new MobilePhone("iPhone", "SE");
            myPhone.PrintDevice();

            // Silver Challenge
            List<Person> people = new List<Person>();
            people.Add(new Person("Dylan", new MobilePhone("Samsung", "S7")));
            people.Add(new Person("Ciprian", new MobilePhone("iPhone", "7")));
            people.Add(new Person("Jeremy", new MobilePhone("iPhone", "SE")));
            people.Add(new Person("Carr", new MobilePhone("Samsung", "S8")));
            people.Add(new Person("Jay", new MobilePhone("iPhone", "4S")));

            foreach (Person p in people)
            {
                Console.WriteLine($"{p.Name} has the {p.Phone}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_GettersSetters
{
    class Employee
    {
        // Backing Field
        private int _id;
        private string _name;

        // Properties
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Employee ID must be a positive integer");
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Employee name must contain characters");
                _name = value.Trim();
            }
        }

    }
}

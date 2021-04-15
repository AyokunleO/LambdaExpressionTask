using System;
using System.Collections.Generic;

namespace SofthillsTech
{
    public class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }
        
        public Employee(string fName, string lName, string position)
        {
            FirstName = fName;
            LastName = lName;
            Position = position;   
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
        
    }
}
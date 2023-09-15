using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Person
{
    
    internal class Relation
    {
        //Fields
        private string relation1;
        private Person person1; 
        private string relation2;
        private Person person2;

        //Properties
        public string Relation1 { get { return relation1; } }
        public string Relation2 { get { return relation2; } }
        public Person Person1 { get { return person1; } }
        public Person Person2 { get { return person2; } }

        //Constructor
        public Relation(string relation1, Person person1, string relation2, Person person2) 
        {
            this.relation1 = relation1;
            this.relation2 = relation2; 
            this.person1 = person1;
            this.person2 = person2;
        }

        public void ShowRelationShip()
        {
            Console.WriteLine($"Relationship between {person1.FirstName} and {person2.FirstName} is: {relation1}hood");
        }
    }
}

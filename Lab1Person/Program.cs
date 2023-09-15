using System.Net.WebSockets;

namespace Lab1Person
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            //create 4 Person objects
            Person person1 = new Person(1,"Ian","Brooks","Red",30,true);
            Person person2 = new Person(2,"Gina","James","Green",18,false);
            Person person3 = new Person(3,"Mike","Briscoe","Blue",45,true);
            Person person4 = new Person(4,"Mary","Beals","Yellow",28,true);

            //display Gina's information as a sentence
            person2.DisplayPersonInfo();

            //display Mike's information as a list
            person3.ToString();

            //change Ian's favorite colour and display
            person1.ChangeFavoriteColour();
            person1.DisplayPersonInfo();

            //display Mary's age in 10 years
            person4.GetAgeInTenYears();

            //create 2 Relation objects
            Relation relation1 = new Relation("Sister", person2, "Sister", person4);
            Relation relation2 = new Relation("Brother", person1, "Brother", person3);
            
            //display relationship
            relation1.ShowRelationShip();
            relation2.ShowRelationShip();

            //create a list and add every person
            List<object> people = new List<object>();
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);

            //determine and calculate the sum of everyone's age
            int sum = 0;

            foreach (Person person in people)
            {
                sum += person.Age;
            }

            //calculate the average of age
            double averageAge = 0;
            double numberOfPeople = people.Count;
            averageAge = sum / numberOfPeople;

            Console.WriteLine($"Average age is: {averageAge}");

            //loop person in people list to find out the smallest age and oldest age
            int smallest = 122;
            int biggest = 0;
            string youngestName = "";
            string oldestName = "";
            foreach (Person person in people)
            {
                if (smallest > person.Age) 
                { 
                    smallest = person.Age;
                    youngestName = person.FirstName;
                } 
                if (biggest < person.Age)
                {
                    biggest = person.Age;
                    oldestName = person.FirstName;
                }
            }

            Console.WriteLine("The youngest person is: " + youngestName);
            Console.WriteLine("The oldest person is: " + oldestName);

            //display people's infomation in a list
            person3.ToString();
            person4.ToString();
            person3.ToString();
        }
    }
}
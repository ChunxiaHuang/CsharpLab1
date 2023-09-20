using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;

namespace Lab1Person
{
    internal class Person
    {
        //Person class for present person information
        //fields of Person
        private int personalId;
        private string firstName;
        private string lastName;
        private string favoriteColour;
        private int age;
        private bool isWorking;

        //properties of Person
        public int Id { get => personalId; set => personalId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age 
        {
            get { return age; }
            set 
            {
                //validate the age
                if (value >= 0 && value <= 122)
                {
                    age = value;
                } 
            }
        }
        public string FavoriteColour { get => favoriteColour; set => favoriteColour = value; }
        public bool IsWorking { get => isWorking; set => isWorking = value; }

        //constructor for Person
        //accepts six attributes to create object of Person
        public Person(int id, string firstName, string lastName, string favoriteColour, int age, bool isWorking) 
        { 
            this.personalId = id;
            this.firstName = firstName;
            this.lastName = lastName;
            FavoriteColour = favoriteColour;
            Age = age;
            IsWorking = isWorking;
        }
        
        //display person info in a sentense
        public string DisplayPersonInfo()
        {
            string formatted = "";
            formatted += personalId + ": " + firstName + " " + lastName + "'s favorite color is " + favoriteColour;

            return formatted;
        }

        //change the person's favorite colour
        public void ChangeFavoriteColour()
        {
            favoriteColour = "White";
        }

        //get the person's age after 10 years
        public int GetAgeInTenYears()
        {
            int ageAfterTenYears = age + 10;
            return ageAfterTenYears;
        }

        //display all person info in a list
        public override string ToString() 
        {
            string formatted = "";
            
            formatted += "PersonId: " + personalId + "\n";
            formatted += "FirstName: " + firstName + "\n";
            formatted += "LastName: " + lastName + "\n";
            formatted += "FavoriteColore: " + favoriteColour + "\n";
            formatted += "Age: " + age + "\n";
            formatted += "IsWorking: " + isWorking;
            
            return formatted;
        }
    }
}
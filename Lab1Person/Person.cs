using System.Net.WebSockets;

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
                if (value >= 0 && value < 122)
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
            this.favoriteColour = favoriteColour;
            this.age = age;
            this.isWorking = isWorking;
        }
        
        //display person info in a sentense
        public void DisplayPersonInfo()
        { 
            Console.WriteLine($"{personalId}: {firstName} {lastName}'s favoirt color is {favoriteColour}");
        }

        //change the person's favorite colour
        public void ChangeFavoriteColour()
        {
            favoriteColour = "White";
        }

        //get the person's age after 10 years
        public void GetAgeInTenYears()
        {
            int ageAfterTenYears = 0;
            ageAfterTenYears = age + 10;
            Console.WriteLine($"{firstName} {lastName}'s Age in 10 years is: {ageAfterTenYears}");
        }

        //display all person info in a list
        public void ToString() 
        {
            Console.WriteLine($"PersonId: {personalId}");
            Console.WriteLine($"FirstName: {firstName}");
            Console.WriteLine($"LastName: {lastName}");
            Console.WriteLine($"FavoriteColour: {favoriteColour}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"IsWorking: {isWorking}");
        }
    }
}
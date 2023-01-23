using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Person
    {
        //Fields
        private int personId;
        private string firstName;
        private string lastName;
        private string favouriteColor;
        private int age;
        private bool isWorking;

        //Constructor
        public Person(int personId, string firstName, string lastName, string favouriteColor, int age, bool isWorking) //creates person objects and assigns attributes
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favouriteColor = favouriteColor;
            this.age = age;
            this.isWorking = isWorking;
        }

        //Methods
        public void DisplayPersonInfo() //displays full name and favourite color       
        {
            //string firstName = this.firstName;
            //string lastName = this.lastName;
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"{personId}: {fullName}'s favourite color is {favouriteColor}");
        }
        public void ChangeFavouriteColor() //change favourite color to white
        {
            favouriteColor = "White";
        }
        public void GetAgeInTenYears() //prints age + 10
        {
            int agePlusTen = age + 10;
            Console.WriteLine($"{firstName} {lastName}'s age in 10 years is: {agePlusTen}");
        }
        public override string ToString() //returns a list of the person's attributes instead of the default Lab1.Person
        {
            return ($"PersonId: {personId}\nFirstName: {firstName}\nLastName: {lastName}\nFavouriteColor: {favouriteColor}\nAge: {age}\nIsWorking: {isWorking}");
        }
    }
}
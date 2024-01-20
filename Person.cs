using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class Person
    {
        public int personid;
        public string firstName;
        public string lastName;
        public string favoriteColour;
        public int age;
        public bool isWorking;


        public Person(int aPersonid, string afirstName, string alastName, string afavouriteColour, int aage, bool aisWorking)
        {
            this.personid = aPersonid;
            this.firstName = afirstName;
            this.lastName = alastName;
            this.favoriteColour = afavouriteColour;
            this.age = aage;
            this.isWorking = aisWorking;
        }

        public string ChnageFavoriteColour(string newColour = "White")
        {
            favoriteColour = newColour;
            return favoriteColour;
        }

        public int GetAgeInTenYears(int incereasedage= 10)
        {
            int newAge = age + incereasedage;
            return newAge;
        }

        public override string ToString()
        {
            string information = $"Person ID : {this.personid} \nFirstName : {this.firstName} \nLastName : {this.lastName} \nFavouriteColour : {this.favoriteColour} \nAge : {this.age} \nIsWorking : {this.isWorking}";
            return information;
        }

        

       
    }
}

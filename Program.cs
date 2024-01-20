using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            //
            Person person1 = new Person(1,"Ian","Brooks","Red",30,true);
            Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);
            Console.WriteLine( person2.firstName + " " +  person2.lastName + " Favourite color is " + person2.favoriteColour);
            Console.WriteLine(person3.ToString());
            person1.ChnageFavoriteColour();
            Console.WriteLine(person1.firstName + " " + person1.lastName + " Favourite color is " + person1.favoriteColour);
            Console.WriteLine( person4.firstName + " " + person4.lastName + "Age in 10 years is : " + person4.GetAgeInTenYears());
            Relation realation1 = new Relation("Sister");
            Relation realation2 = new Relation("Brother");
            Console.WriteLine(realation1.ShowRelationShip("Gina","mary" + "Hood"));
            Console.WriteLine(realation2.ShowRelationShip("Lan", "Mike" + "Hood"));
            List<Person> personslist = new List<Person>();
            personslist.Add(person1);
            personslist.Add(person2);
            personslist.Add(person3);
            personslist.Add(person4);

            foreach(var person in personslist)
            {
                Console.WriteLine($"Person ID : {person.personid} \nFirstName : {person.firstName} \nLastName : {person.lastName} \nFavouriteColour : {person.favoriteColour} \nAge : {person.age} \nIsWorking : {person.isWorking}");

            }

            int maxAge = int.MinValue;  
            string youngestperson = "";

            foreach (var person in personslist)
            {
                if (person.age > maxAge)
                {
                    maxAge = person.age;
                    youngestperson = person.firstName;
                }
            }

            Console.WriteLine("The oldest person is " + youngestperson);

            int minAge = int.MaxValue;
            string oldestperson = "";

            foreach (var person in personslist)
            {
                if (person.age < minAge)
                {
                    minAge = person.age;
                    oldestperson = person.firstName;
                }
            }
            Console.WriteLine("The youngest person is " + oldestperson);


            //----------------------------------------------------------

            string StartsWithM = "" ;

            foreach (var peroson in personslist)
            {
                if (peroson.firstName.StartsWith("M") )
                {
                    StartsWithM = peroson.firstName;

                    Console.WriteLine($"Person ID : {peroson.personid} \nFirstName : {peroson.firstName} \nLastName : {peroson.lastName} \nFavouriteColour : {peroson.favoriteColour} \nAge : {peroson.age} \nIsWorking : {peroson.isWorking}");
                } 
            }
          

            //---------------------------------------------------------
           
            foreach(var color in personslist)
            {
                if (color.favoriteColour.Contains("Blue"))
                {
                    Console.WriteLine($"Person ID : {color.personid} \nFirstName : {color.firstName} \nLastName : {color.lastName} \nFavouriteColour : {color.favoriteColour} \nAge : {color.age} \nIsWorking : {color.isWorking}");
                }
            }
            Console.ReadLine();
        }
    }
}

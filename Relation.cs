using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class Relation
    {
        public string RealtionshipType;



        public Relation(string aRealtionshipType) 
        { 
            RealtionshipType = aRealtionshipType;
        }

        public string ShowRelationShip(string firstPerson, string SecondPerson)
        {
            string information = $"Realtionship Between {firstPerson} and {SecondPerson} is {this.RealtionshipType}"; 
            return information;

        }

        
    }
}

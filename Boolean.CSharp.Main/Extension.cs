using Boolean.CSharp.Main.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Extension
    {
        private Core _core;
        public Extension()
        {
            Core core = new Core();
        }

        public Aeroplane Question1()
        {
            Aeroplane plane = new Aeroplane();
            plane.FlightDetails("LHR", "JFK");

            //TODO: 1.  Overload FlightDetails() (add new method) that returns an int of the number of passengers on the flight.  

            //TIP: Try passing in the passinger list? and returning the passingers.NumberOfPassengers() inside the method?

            AeroplanePassengerManifest currentListOfPassengers = new AeroplanePassengerManifest();

            //write calling code here and method inside the Aeroplane class.
            plane.FlightDetails(currentListOfPassengers);
            

            return plane;
        }
        public bool Question2()
        {
            Aeroplane plane = new Aeroplane();
            plane.FlightDetails("LHR", "JFK");

            //TODO 2.  Overload FlightDetails (add new method) that adds another passenger to the flight.  
            //TIP - you cant write a method that takes a single string as the cancelled flight one already does this, so use a 
            //      different number of params            

            //write calling code here and method inside the Aeroplane class.
            AeroplanePassengerManifest currentListOfPassengers = new AeroplanePassengerManifest();
            plane.FlightDetais(currentListOfPassengers, "Stavros Spiliopoulos");

            if (currentListOfPassengers.Passengers.Contains("Stavros Spiliopoulos"))
            {
                return true;
            }
            return false;
         
        }
    }
}

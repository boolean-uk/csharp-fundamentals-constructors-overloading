using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Misc
{
    public class Aeroplane
    {
        private string _departureAirport;
        private string _arrivalAirport;
        private string _journeyDetails;
        private bool _flightCancelled;
        public AeroplanePassengerManifest _passengerManifest;   //added for manifest and changed to public
        
        public Aeroplane()
        {
            
        }
        public bool FlightDetails(string departureAirport, string arrivalAirport) 
        {
            _departureAirport = departureAirport;
            _arrivalAirport = arrivalAirport;
            _journeyDetails = $"##{_departureAirport}##{_arrivalAirport}##";
            _flightCancelled = false;
            return _flightCancelled;        
        }  
       
        public void FlightDetails(string cancelledMessage)
        {
            _journeyDetails = cancelledMessage;
            _flightCancelled = true;            
        }
            
        public string FlightDetails()
        {
            return _journeyDetails;
        }

        
        public void FlightDetails(AeroplanePassengerManifest list)
        {
            _passengerManifest = list; // added list
        }
        //added new method to get amount of passengers
        public int Getnumbers()
        {
            return _passengerManifest?.NumberOfPassengers ?? 0;
        }
        // overloading
        public void AddPassenger(string newPassenger)
        {
            if (_passengerManifest == null) 
                _passengerManifest = new AeroplanePassengerManifest();
            _passengerManifest.Passengers.Add(newPassenger);
        }
        
        
        public bool IsFlightCancelled => _flightCancelled;
    
    
    
    }
}

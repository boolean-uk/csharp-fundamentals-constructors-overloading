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
        private List<string> _passengersList;
        
        public Aeroplane()
        {
            _passengersList = new List<string>();
            
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

        
        public int FlightDetails(AeroplanePassengerManifest list)
        {
            _passengersList = list.Passengers;
            return list.NumberOfPassengers;
        }

        public void FlightDetails(string prefix, string firstName, string lastName)
        {
            _passengersList.Add($"{prefix} {firstName} {lastName}");
        }
        
        
        public bool IsFlightCancelled => _flightCancelled;
    
        public int PassengersNum => _passengersList.Count;    
    
    }
}

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

        
        public int FlightDetails(AeroplanePassengerManifest list)
        {
            return list.NumberOfPassengers;
            throw new NotImplementedException();
        }

        public void FlightDetais(AeroplanePassengerManifest list, string name)
        {
            list.Passengers.Add(name);
        }
        
        
        
        public bool IsFlightCancelled => _flightCancelled;
    
    
    
    }
}

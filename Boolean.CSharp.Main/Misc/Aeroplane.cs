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
        private int _numberOfPassengers;
        
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

        AeroplanePassengerManifest currentListOfPassengers = new AeroplanePassengerManifest();

        public void FlightDetails(int numberOfPassengers)
        {
            _numberOfPassengers = numberOfPassengers;
            //throw new NotImplementedException();
        }
        
        
        
        public bool IsFlightCancelled => _flightCancelled;
        public int NumberOfPassengers => _numberOfPassengers;
    
    
    
    }
}

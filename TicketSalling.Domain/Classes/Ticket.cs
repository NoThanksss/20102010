using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;


namespace TicketSalling
{ 
   public class Ticket
    {
        private Flight flight;
        
        private Passenger passenger;
        
        private Pilot pilot;

        public Ticket(Flight flight, Passenger passenger, Pilot pilot)
        {
            this.flight = flight;
            this.passenger = passenger;
            this.pilot = pilot;
        }

        public override string ToString()
        {
            return flight.ToString() + "                 " +  pilot.ToString() +"                     "+ passenger.ToString();

        }
    }
}

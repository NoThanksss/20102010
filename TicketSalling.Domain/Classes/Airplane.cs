using System;
using System.Collections.Generic;
using System.Text;

namespace TicketSalling 
{
   public class Airplane : IEquatable<Airplane>
    {
        public Time time;
        public Airports airport;
        private int Amount;
        public int amount
        {
            get { return Amount; } 
            private set { Amount = value; }
        }

        public Airplane(Time time, Airports airport, int amount)
        {
            this.airport = airport;
            this.time = time;
            this.amount = amount;

        }
        public bool Equals(Airplane other)
        {
            if (this.airport.Equals(other.airport) && this.time.Equals(other.time))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Reduce(int passengersN)
        {
            this.amount = amount - passengersN;
            return this.amount;
        }

        public override string ToString()
        {
            return airport.from + " --> " + airport.to +
                   " there: " + time.there + " back: " + time.back + "free places: " + amount;
        }


    }
}

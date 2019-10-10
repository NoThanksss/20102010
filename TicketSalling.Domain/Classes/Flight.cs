using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSalling;

namespace TicketSalling
{
    public class Flight : IEquatable<Flight>
    {
        public Airplane airplane;
        public int race;
        public int cost;
        public int PassengersN;

        public int passengersN
        {
            get { return PassengersN; }
            private set
            {
                if (value > 0)
                {
                    PassengersN = value;
                }
            }
        }
        //public int amount
        //{
        //    get { return Amount; }
        //    private set
        //    {
        //        if (value > 0)
        //        {
        //            Amount = value;
        //        }
        //    }
        //}

        public Flight(Airplane airplane, int race, int cost)
        {
            this.airplane = airplane;
            this.race = race;
            this.cost = cost;
        }

    
        //public int Reduce()
        //{
        //    this.airplane.amount = amount - passengersN;
        //    return this.amount;
        //}
        public int PassN(int numb)
        {
            this.passengersN = numb;
            return numb;
        }

        public override string ToString()
        {
            return airplane.ToString() + " Race: " + race + " cost: " + cost + "$" ;
        }

        public bool Equals(Flight other)
        {
            if (this.airplane.Equals(other.airplane))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public override int GetHashCode()
        {
            return (airplane != null ? airplane.GetHashCode() : 0);
        }
    }
}


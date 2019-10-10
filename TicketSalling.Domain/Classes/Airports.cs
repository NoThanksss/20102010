using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSalling
{
   public class Airports : IEquatable<Airports>
    {
       private string From;
        public string from
        {
            get { return From; }
           private set
            {
                if (value.Length > 0)
                {
                    From = value;
                }
            }
        }
        private string To;
        public string to
        {
            get { return To; }
           private set
            {
                if (value.Length > 0)
                {
                    To = value;
                }
            }
        }
        public Airports(string from, string to) {
            this.from = from;
            this.to = to;
        }

        public bool Equals(Airports other)
        {
            if (this.from == other.from && this.to == other.to)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

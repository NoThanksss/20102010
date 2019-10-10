using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TicketSalling
{
   public class Time : IEquatable<Time>
    {
        Exception ex = new Exception("choose correct Date");
        DateTimeOffset There;
        public DateTimeOffset there { get { return There; }
           private set
            {
                There = value;
                if (value < DateTime.Today)
                {
                    throw ex;
                }
            }
        }
        DateTimeOffset Back;
        public DateTimeOffset back
        {
            get { return Back; } 
            private set
            {
              
                    Back = value;
                    if (value < there && value < DateTime.Today)
                    {
                        throw  ex;
                    }
            }
        }

        private Exception IndexOutOfRangeException()
        {
            throw new IndexOutOfRangeException();
        }

        public Time(DateTimeOffset there, DateTimeOffset back) {
            this.there = there;
            this.back = back;

        }

    public bool Equals(Time other)
        {
            if (this.there == other.there && this.back == other.back)
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

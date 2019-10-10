using System;
using System.Collections.Generic;
using System.Text;

namespace TicketSalling
{
    public class Pilot: Person
    {
        private int Hours;
        public int hours
        {
            get { return Hours; }
            private set
            {
                if (value > 0)
                {
                    Hours = value;
                }
            }
        }
        private int Rating;
        public int rating
        {
            get { return Rating; }
            private set
            {
                if (value > 0)
                {
                    Rating = value;
                }
            }

        }

        public Pilot(string sex, string name, string secondName, DateTime birthday, int hours, int rating) : base(sex, name,
            secondName, birthday)
        {
            this.hours = hours;
            this.rating = rating;
        }

        public override string ToString()
        {
            return " Pilot: " + name + " " + secondName + "; Birthday: " + birthday.ToString() + " y.o; Experience: " + hours + " hours; Rating: " + rating + "/10 ;";
        }
    }
}

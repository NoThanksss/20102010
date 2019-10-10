using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSalling
{
   public class Passenger: Person
   {
   
      private long Document;
       public long document
       {
           get { return Document; }
           private set
           {
               if (value > 0)
               {
                   Document = value;
               }
            }

       }
       
       private DateTime Date;
        public DateTime date
        {
            get { return Date; }
            private set
            {
                if (value.Day > 0)
                {
                    Date = value;
                    if (value <= DateTime.Today)
                    {
                        throw new Exception("change your passport");
                    }
                }
            }
        }


        public Passenger(string sex, string name, string secondName, DateTime birthday, long document, DateTime date) : base(sex, name, secondName, birthday)
        {
            this.document = document;
            this.date = date;
        }

        public override string ToString()
        {
            return "Passenger: Sex: " + sex + "; Name: " + name + "; Surname: " + secondName + "; Birthday: " + birthday.ToString() + "; Document: " + document + "; Date of Expire:  " + date;
        }
   }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TicketSalling
{
   public class Person
    {
        private string Sex;
        public string sex
        {
            get { return Sex; }
            protected set
            {
                if (value.Length > 0)
                {
                    Sex = value;
                }
            }
        }
        private string Name;
        public string name
        {
            get { return Name; }
            protected set
            {
                if (value.Length > 0)
                {
                    Name = value;
                }
            }
        }
        private string SecondName;
        public string secondName
        {
            get { return SecondName; }
            protected set
            {
                if (value.Length > 0)
                {
                    SecondName = value;
                }
            }
        }
        private DateTime Birthday;
        public DateTime birthday
        {
            get { return Birthday; }
            protected set
            {
                if (value.Year > 1900)
                {
                    Birthday = value;
                    if (value > DateTime.Today)
                    {
                        throw new Exception("impossible");
                    }
                }
            }
        }
        public Person(string sex, string name, string secondName, DateTime birthday)
        {
            this.sex = sex;
            this.name = name;
            this.secondName = secondName;
            this.birthday = birthday;

        }
    }
}

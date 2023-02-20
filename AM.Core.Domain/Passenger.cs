using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public  class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        private int age;
        public int Age
        {
            get
            {
                age =DateTime.Now.Year - BirthDate.Year;
                if(BirthDate.Month > DateTime.Now.Month) {
                    age -= 1;

                }
                else if(BirthDate.Month==DateTime.Now.Month && BirthDate.Day > DateTime.Now.Day)
                {
                    age--;
                }
                return age;
            }
        }
        public IList<Flight> Flights { get; set; }


//question 11
       // public bool CheckProfile(string nom, string prenom)
       // {
       //     return LastName == nom && FirstName == prenom ;
       //
       // }
       // public bool CheckProfile(string email, string nom, string prenom)
       // {
       //     return EmailAddress==email && LastName==nom && FirstName==prenom;   
       // }
       //question 11/C
        public bool CheckProfile( string nom, string prenom,string email=null)
        {
            return EmailAddress == email && LastName == nom && FirstName == prenom;
        }
        //quetsion 12
               public virtual string GetPassengerType() { 
            return "I am a passenger"; } 

        public void GetAge(DateTime birthDate, int calculatedAge)
        {
           calculatedAge = DateTime.Now.Year- birthDate.Year;
            if(birthDate.Month< DateTime.Now.Month )
            {
                calculatedAge -= 1;
            }
            else if (birthDate.Month == DateTime.Now.Month && birthDate.Day>DateTime.Now.Day)
            {
 calculatedAge -= 1;
            }
        }
        public void GetAge(Passenger apassenger)
        {
            apassenger.age = DateTime.Now.Year - apassenger.BirthDate.Year;
            if (apassenger.BirthDate.Month < DateTime.Now.Month)
            {
                apassenger.age -= 1;
            }
            else if (apassenger.BirthDate.Month == DateTime.Now.Month && apassenger.BirthDate.Day > DateTime.Now.Day)
            {
                apassenger.age -= 1;
            }
        }

        public override string ToString()
        {
            return "BirthDate;" + BirthDate + ";PassportNumber:" + PassportNumber + ";EmailAddress:" + EmailAddress +
                ";FirstName:" + FirstName + ";LastName:" + LastName + ";TelNumber:" + TelNumber;
        }

    }  
}

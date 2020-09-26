using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc2_person
{
    class Person
    {
        private string firstName;
        private string lastName;
        private string emailAddress;
        private DateTime dOB;


        public Person()
        {

        }
        public Person(string firstName, string lastName, string emailAddress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
        }
        public Person(string firstName, string lastName, DateTime dOB)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dOB = dOB;
        }
        public Person(string firstName, string lastName, string emailAddress, DateTime dOB)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.dOB = dOB;
        }



        //public DOB(get =>DOB.ToSTring(); Set => DOB = new DataTime(convert.ToInt32(value.Substring(4,2)),convert.ToInt32(value Substring(6,2)));}
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public DateTime DOB { get => dOB; set => dOB = value; }

        public bool Adult
        {
            get
            {
                if ((DateTime.Today.Year - DOB.Year) >= 18)
                    return true;
                else
                    return false;
            }
        }
        public string SunSign
        {
            get
            {
                switch (dOB.Month)
                {
                    case 1:
                        if (dOB.Day <= 20)
                        {
                            return "Capricorn";
                        }
                        else
                            return "Aquaries";
                    //break;
                    case 2:
                        if (dOB.Day <= 18)
                        {
                            return "Aquaries";
                        }
                        else
                            return "Pisces";
                    default:
                        return "null";
                }
            }
        }
        public bool BirthDay
        {
            get
            {
                if ((dOB.Month == DateTime.Today.Month) && (dOB.Month == DateTime.Today.Month))
                {
                    return true;
                }
                else
                    return false;
            }
        }
        public string ScreenName
        {
            get
            {
                string screenName;
                screenName = firstName.Substring(0, 4) + dOB.Month.ToString();
                return screenName;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string fName, lName, email, dOB;
            Console.WriteLine("enter the First Name");
            fName = Console.ReadLine();
            Console.WriteLine("enter the Last Name");
            lName = Console.ReadLine();
            Console.WriteLine("enter the Email Address");
            email = Console.ReadLine();
            Console.WriteLine("enter the date of birth in the format year,month and day");
            dOB = Console.ReadLine();
            DateTime dT = new DateTime(Convert.ToInt32(dOB.Substring(0, 4)));
            Person p1 = new Person(fName, lName, email, dT);
            Console.WriteLine("the person is an adult?:" + p1.Adult);
            Console.WriteLine("the sunsign:" + p1.SunSign);
            Console.WriteLine("toad is BirthDay?:" + p1.BirthDay);
            Console.WriteLine("the allotted screen name:" + p1.ScreenName);
            Console.ReadLine();




        }
    }
}

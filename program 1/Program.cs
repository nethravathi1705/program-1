﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_1
{
    class Program
    {
        static void Main(string[] args)
        { 
                int year;   //of birth
                int month;
                int day;

                //read the date[y,m and day from the user]
                //read each one separately

                Console.WriteLine("enter the year");
                year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter the month");
                month = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter the day");
                day = Convert.ToInt32(Console.ReadLine());

                //rcode=1 then it means the i/p date is future date
                //  rcode=2 then it means age of the person is going >=135
                //else its the age of the user
                //   rcode=0 born today

                int rcode = checkthebirthdate(year, month, day);

                switch (rcode)
                {
                    case 0:
                        Console.WriteLine("hey you are born today. welcome!!!");
                        break;

                    case 1:
                        Console.WriteLine("uh have entered a future date....");
                        break;

                    case 2:
                        Console.WriteLine("your are lucky to have lived >= 135");
                        break;

                    case -1:
                        Console.WriteLine("you are less than 1 year old");
                        break;

                    default:
                        Console.WriteLine("age of the user is :" + rcode);
                        if (TodayBirthday(month, day))
                            Console.WriteLine("happy birthday");

                        Console.WriteLine(DisplayAstrologicalsign(month, day));


                        break;
                }
                Console.Read();
            }

            private static string DisplayAstrologicalsign(int month, int day)
            {
                switch (month)
                {
                    case 1:
                        if (day <= 20)
                        {
                            return "Capricorn";
                        }
                        else
                            return "aquarius";


                    case 2:
                        if (day <= 18)
                        {
                            return "aquarius";
                        }
                        else
                            return "pisces";


                    case 3:
                        if (day <= 20)
                        {
                            return "pisces";
                        }
                        else
                            return "Aries";

                    default: return "null";

                }
            }

            private static bool TodayBirthday(int month, int day)
            {
                DateTime tdy = DateTime.Today;
                // if(month==tdy.Month && day == tdy.Day) or
                if (month == DateTime.Today.Month && day == DateTime.Today.Day)
                    return true;
                else
                    return false;
            }

            private static int checkthebirthdate(int year, int month, int day)
            {
                DateTime bDate = new DateTime(year, month, day);
                DateTime tDate = DateTime.Today;
                int rvalue = DateTime.Compare(bDate, tDate);
                if (rvalue < 0)
                {
                    if ((tDate.Year - bDate.Year) >= 135)
                        return 2;
                    else
                        if ((tDate.Year - bDate.Year) == 0)
                        return -1;
                    else
                        return (tDate.Year - bDate.Year);

                }
                else if (rvalue >= 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }

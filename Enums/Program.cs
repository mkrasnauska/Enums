using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thrusday,
        Friday,
        Saturday,
        Sunday

    }
    class MyClass
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a day of the week");
            string YourDay = Console.ReadLine();
            string ActualDay = DateTime.Now.DayOfWeek.ToString();
            try
            {
                if (YourDay == ActualDay)
                {
                    Console.WriteLine("Today is : " + YourDay);
                }
                {
                    if (YourDay != ActualDay)
                        throw new ArgumentNullException();
                }
            }
            catch (ArgumentNullException)

            {
                Console.WriteLine("Please enter an actual day of the week");
            }

            finally
            {
                Console.ReadLine();
            }
        }
    }
}
// By default, the first value in an enum starts with 0, 
// and each subsequent value increments by 1:


using System.ComponentModel;
namespace EnumerationTypes
{
    enum Day
    {
        [Description("This is just example of how to use Description attribute")]
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }


// You cannot define a method inside the definition of an enumeration type
    static class DayExtensions
    {
        public static bool IsWeekend(this Day day)
        {
            return day == Day.Saturday || day == Day.Sunday;
        }
    }

}




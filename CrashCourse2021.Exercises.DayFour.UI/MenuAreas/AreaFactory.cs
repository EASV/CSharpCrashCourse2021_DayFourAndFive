using CrashCourse2021.Exercises.DayFour.UI.Customers;
using CrashCourse2021.Exercises.DayFour.UI.Videos;

namespace CrashCourse2021.Exercises.DayFour.UI.MenuAreas
{
    public class AreaFactory
    {
        public ICRUDMenuOptionsFactory GetOptionsFactory(Areas area)
        {
            switch (area)
            {
                case Areas.Video:
                    return new VideoCRUDMenuOptionsFactory();
                case Areas.Customer:
                    return new CustomerCRUDMenuOptionsFactory();
                case Areas.Exit:
                    return new ExitCRUDMenuOptionsFactory();
            }
            return null;
        }
    }
}
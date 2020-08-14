using CrashCourse2020ExercisesDayFourUI.Customers;
using CrashCourse2020ExercisesDayFourUI.Videos;

namespace CrashCourse2020ExercisesDayFourUI.MenuAreas
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
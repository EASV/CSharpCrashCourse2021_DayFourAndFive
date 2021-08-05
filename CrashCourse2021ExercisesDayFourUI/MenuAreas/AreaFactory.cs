using CrashCourse2021ExercisesDayFourUI.Customers;
using CrashCourse2021ExercisesDayFourUI.Videos;

namespace CrashCourse2021ExercisesDayFourUI.MenuAreas
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
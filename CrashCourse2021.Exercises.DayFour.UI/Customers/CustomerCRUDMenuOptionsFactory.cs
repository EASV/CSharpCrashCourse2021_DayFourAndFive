using CrashCourse2021.Exercises.DayFour.UI.Customers.Builders;
using CrashCourse2021.Exercises.DayFour.UI.MenuAreas;

namespace CrashCourse2021.Exercises.DayFour.UI.Customers
{
    public class CustomerCRUDMenuOptionsFactory: ICRUDMenuOptionsFactory
    {
        public IConsoleOutputBuilder GetOutputBuilder(CRUDMenuOptions option)
        {
            switch (option)
            {
                case CRUDMenuOptions.ReadById:
                    var builder = new CustomerByIdBuilder();
                    builder.CreateData();
                    return builder;
            }
            return null;
        }

        public IConsoleOutputBuilder GetMenu()
        {
            return new CustomerMenuBuilder();
        }
    }
}
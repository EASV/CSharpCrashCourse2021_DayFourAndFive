using CrashCourse2021ExercisesDayFourUI.Customers.Builders;
using CrashCourse2021ExercisesDayFourUI.MenuAreas;

namespace CrashCourse2021ExercisesDayFourUI.Customers
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
using CrashCourse2021.Exercises.DayFour.Services.Implementation;
using CrashCourse2021.Exercises.DayFour.UI.Utils;

namespace CrashCourse2021.Exercises.DayFour.UI.Customers
{
    public abstract class CustomerBuilder: IConsoleOutputBuilder
    {
        protected readonly CustomerService customerService;
        protected readonly MenuUtils menuUtils;
        protected CustomerBuilder()
        {
            customerService = new CustomerService();
            menuUtils = new MenuUtils();
        }

        public abstract string GetConsoleOutputAsString();
        
    }
}
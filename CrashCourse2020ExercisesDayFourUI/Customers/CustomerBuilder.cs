using CrashCourse2020ExercisesDayFourService.Customers;
using CrashCourse2020ExercisesDayFourService.Videos;
using CrashCourse2020ExercisesDayFourUI.Utils;

namespace CrashCourse2020ExercisesDayFourUI.Customers
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
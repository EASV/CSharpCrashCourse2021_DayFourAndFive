using CrashCourse2021ExercisesDayFourService.Customers;
using CrashCourse2021ExercisesDayFourService.Videos;
using CrashCourse2021ExercisesDayFourUI.Utils;

namespace CrashCourse2021ExercisesDayFourUI.Customers
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
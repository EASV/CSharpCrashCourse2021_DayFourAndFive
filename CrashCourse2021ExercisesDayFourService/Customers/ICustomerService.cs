using CrashCourse2021ExercisesDayFourModels;

namespace CrashCourse2021ExercisesDayFourService.Customers
{
    public interface ICustomerService
    {
        Customer ReadById(int id);
    }
}
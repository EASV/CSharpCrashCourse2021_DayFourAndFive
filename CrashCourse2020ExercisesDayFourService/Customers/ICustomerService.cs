using CrashCourse2020ExercisesDayFourModels;

namespace CrashCourse2020ExercisesDayFourService.Customers
{
    public interface ICustomerService
    {
        Customer ReadById(int id);
    }
}
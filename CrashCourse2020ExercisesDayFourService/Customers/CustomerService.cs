using CrashCourse2020ExercisesDayFourDataLayer;
using CrashCourse2020ExercisesDayFourModels;

namespace CrashCourse2020ExercisesDayFourService.Customers
{
    public class CustomerService: ICustomerService
    { 
        private readonly CustomerTable _table;
        public CustomerService()
        {
            _table = CustomerTable.GetInstance();
        }
        public Customer ReadById(int id)
        {
            return _table.GetCustomerById(id);
        }
    }
}
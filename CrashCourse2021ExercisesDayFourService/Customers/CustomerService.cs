using CrashCourse2021ExercisesDayFourDataLayer;
using CrashCourse2021ExercisesDayFourModels;

namespace CrashCourse2021ExercisesDayFourService.Customers
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
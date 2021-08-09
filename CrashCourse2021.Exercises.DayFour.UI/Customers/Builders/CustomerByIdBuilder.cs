using CrashCourse2021.Exercises.DayFour.Models;

namespace CrashCourse2021.Exercises.DayFour.UI.Customers.Builders
{
    public class CustomerByIdBuilder: CustomerBuilder
    { 
        private Customer _customer;

        public override string GetConsoleOutputAsString()
        {
            if (_customer == null)
            {
                return $"Customer with not found!\n";
            }
            return $"Id: {_customer.Id} \n" +
                   $"FirstName: {_customer.FirstName} \n" +
                   $"LastName: {_customer.LastName} \n";
        }
        
        public void CreateData()
        {
            menuUtils.ReadIntegerFromString("Type in the Id of the item you search for:", out var id);
            _customer = customerService.ReadById(id);
        }
    }
}
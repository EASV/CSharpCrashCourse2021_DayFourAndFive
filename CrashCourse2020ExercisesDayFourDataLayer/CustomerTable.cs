using System.Collections.Generic;
using CrashCourse2020ExercisesDayFourModels;

namespace CrashCourse2020ExercisesDayFourDataLayer
{
    public class CustomerTable
    {
        private static int _id;
        private static CustomerTable _instance;
        private static List<Customer> _customers;

        private CustomerTable()
        {
            _customers = new List<Customer>();
            _id = 0;
            InitCustomers();
        }

        private void InitCustomers()
        {
            _customers.Add(new Customer
            {
                Id = ++_id,
                FirstName = "John",
                LastName = "Doe"
            });
        }
        public static CustomerTable GetInstance()
        {
            return _instance ??= new CustomerTable();
        }
        
        public Customer GetCustomerById(int id)
        {
            return _customers.Find(c => c.Id == id);
        }
    }
}
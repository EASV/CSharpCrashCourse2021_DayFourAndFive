using System.Collections.Generic;
using System.IO;
using CrashCourse2021.Exercises.DayFour.DataLayer;
using CrashCourse2021.Exercises.DayFour.Models;

namespace CrashCourse2021.Exercises.DayFour.Services.Implementation
{
    public class CustomerService: ICustomerService
    { 
        private readonly CustomerTable _table;
        public CustomerService()
        {
            _table = CustomerTable.GetInstance();
        }

        public List<Customer> ReadAll()
        {
            throw new System.NotImplementedException();
        }

        public Customer ReadById(int id)
        {
            if (id <= 0)
            {
                throw new InvalidDataException(Constants.IdCannotBeLessThenOne);
            }
            return _table.GetCustomerById(id);
        }

        public Customer Create(string firstName, string lastName)
        {
            throw new System.NotImplementedException();
        }

        public Customer Update(int id, string firstName, string lastName)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
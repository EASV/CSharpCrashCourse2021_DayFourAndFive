using System.Collections.Generic;
using CrashCourse2021.Exercises.DayFour.Models;

namespace CrashCourse2021.Exercises.DayFour.Services
{
    public interface ICustomerService
    {
        List<Customer> ReadAll();
        Customer ReadById(int id);
        
        Customer Create(string firstName, string lastName);

        Customer Update(int id, string firstName, string lastName);
        
        bool Delete(int id);
    }
}
using System;
using System.IO;
using CrashCourse2021.Exercises.DayFour.Services.Implementation;
using Xunit;

namespace CrashCourse2021.Exercises.DayFour.Services.Tests.Implementation
{
    public class CustomerServiceTest
    {
        [Fact]
        public void Service_IsAssignableFrom_ICustomerService()
        {
            Assert.IsAssignableFrom<ICustomerService>(GetCustomerService());
        }
        
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(int.MinValue)]
        public void ReadById_WithNumberZeroOrLess_ThrowsException(int input)
        {
            var customerService = GetCustomerService();
            var exception = Assert.Throws<InvalidDataException>(() => customerService.ReadById(input));
            Assert.Equal(Constants.IdCannotBeLessThenOne, exception.Message);
        }
        
        [Theory]
        [InlineData("")]
        [InlineData("a")]
        [InlineData("z")]
        public void Create_WithFirstNameOfOneOrLessCharacters_ThrowsException(string input)
        {
            var customerService = GetCustomerService();
            var exception = Assert.Throws<InvalidDataException>(() => customerService.Create(input, "Doe"));
            Assert.Equal(Constants.FirstNameMustBeMoreThenOneCharacter, exception.Message);
        }
        
        [Theory]
        [InlineData("aaaa1bbbb2cccc3dddd4eeee5ffff67")] //31 chars
        [InlineData("aaaa1bbbb2cccc3dddd4eeee5ffff67aaaa1bbbb2cccc3dddd4eeee5ffff67")] //62 chars
        public void Create_WithFirstNameOfThirtyOneOrMoreCharacters_ThrowsException(string input)
        {
            //30 or more.
            var customerService = GetCustomerService();
            var exception = Assert.Throws<InvalidDataException>(() => customerService.Create(input, "Doe"));
            Assert.Equal(Constants.FirstNameMustBeThirtyOrLessCharacters, exception.Message);
        }
        
        [Theory]
        [InlineData("")]
        [InlineData("a")]
        [InlineData("z")]
        public void Create_WithLastNameOfOneOrLessCharacters_ThrowsException(string input)
        {
            var customerService = GetCustomerService();
            var exception = Assert.Throws<InvalidDataException>(() => customerService.Create("John", input));
            Assert.Equal(Constants.LastNameMustBeMoreThenOneCharacter, exception.Message);
        }
        
        [Theory]
        [InlineData("aaaa1bbbb2cccc3dddd4eeee5ffff67")] //31 chars
        [InlineData("aaaa1bbbb2cccc3dddd4eeee5ffff67aaaa1bbbb2cccc3dddd4eeee5ffff67")] //62 chars
        public void Create_WithLastNameOfThirtyOneOrMoreCharacters_ThrowsException(string input)
        {
            //30 or more.
            var customerService = GetCustomerService();
            var exception = Assert.Throws<InvalidDataException>(() => customerService.Create("John", input));
            Assert.Equal(Constants.LastNameMustBeThirtyOrLessCharacters, exception.Message);
        }

        private ICustomerService GetCustomerService()
        {
            return new CustomerService();
        }
    }
}
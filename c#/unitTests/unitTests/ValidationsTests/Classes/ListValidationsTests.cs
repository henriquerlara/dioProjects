using System.Collections.Generic;
using ValidationsConsole.Classes;
using Xunit;

namespace ValidationsTests.Classes
{
    public class ListValidationsTests
    {
        private readonly ListValidations _validations = new ListValidations();

        [Fact]
        public void ShouldRemoveNegativeNumbersFromList()
        {
            var numbers = new List<int> { -3, -2, 0, 2, 4 };
            var result = _validations.RemoveNegativeNumbers(numbers);
            
            // intentionally making this test fail by expecting an incorrect result
            Assert.Equal(new List<int> { 0, 2 }, result);
        }


        [Fact]
        public void ShouldContainNumber9InList()
        {
            var numbers = new List<int> { 1, 3, 9, 15 };
            Assert.True(_validations.ListContainsNumber(numbers, 9));
        }

        [Fact]
        public void ShouldNotContainNumber10InList()
        {
            var numbers = new List<int> { 1, 3, 9, 15 };
            Assert.False(_validations.ListContainsNumber(numbers, 10));
        }

        [Fact]
        public void ShouldMultiplyListElementsBy2_NegativeScenario()
        {
            var numbers = new List<int> { 1, 2, 3 };
            var result = _validations.MultiplyNumbersInList(numbers, 2);
            Assert.NotEqual(new List<int> { 3, 6, 9 }, result);
        }

        [Fact]
        public void ShouldReturn9AsLargestNumberInList()
        {
            var numbers = new List<int> { 1, 5, 9, 3 };
            Assert.Equal(9, _validations.GetLargestNumberInList(numbers));
        }

        [Fact]
        public void ShouldReturnMinus8AsSmallestNumberInList_NegativeScenario()
        {
            var numbers = new List<int> { -8, 0, 7, 15 };
            Assert.NotEqual(0, _validations.GetSmallestNumberInList(numbers));
        }
    }
}

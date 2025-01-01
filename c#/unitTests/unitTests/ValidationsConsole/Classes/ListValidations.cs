using System.Collections.Generic;
using System.Linq;

namespace ValidationsConsole.Classes
{
    public class ListValidations
    {
        public List<int> RemoveNegativeNumbers(List<int> numbers)
        {
            return numbers.Where(n => n >= 0).ToList();
        }

        public bool ListContainsNumber(List<int> numbers, int number)
        {
            return numbers.Contains(number);
        }

        public List<int> MultiplyNumbersInList(List<int> numbers, int multiplier)
        {
            return numbers.Select(n => n * multiplier).ToList();
        }

        public int GetLargestNumberInList(List<int> numbers)
        {
            return numbers.Max();
        }

        public int GetSmallestNumberInList(List<int> numbers)
        {
            return numbers.Min();
        }
    }
}

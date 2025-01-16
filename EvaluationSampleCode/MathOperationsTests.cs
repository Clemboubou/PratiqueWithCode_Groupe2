using System;

namespace EvaluationSampleCode
{
    public class MathOperationsTests
    {
        public void SubtractTests()
        {
            TestSubtract(10, 5, 5); 
            TestSubtract(5, 10, -1, true); 
            TestSubtract(1200, 10, -1, true); 
        }

        private void TestSubtract(int num1, int num2, int expected, bool shouldThrow = false)
        {
            var math = new MathOperations();
            try
            {
                var result = math.Subtract(num1, num2);
                if (shouldThrow)
                {
                    Console.WriteLine($"Test Failed for {num1} - {num2}: Exception was expected.");
                }
                else
                {
                    Console.WriteLine(result == expected
                        ? $"Test Passed for {num1} - {num2}"
                        : $"Test Failed: Expected {expected}, but got {result}");
                }
            }
            catch (ArgumentException ex)
            {
                if (shouldThrow)
                {
                    Console.WriteLine($"Test Passed for {num1} - {num2} (Exception as expected): {ex.Message}");
                }
                else
                {
                    Console.WriteLine($"Test Failed: Unexpected exception - {ex.Message}");
                }
            }
        }

        public void GetColorFromOddsNumberTests()
        {
            TestGetColorFromOddsNumber(3, "Blue");
            TestGetColorFromOddsNumber(4, "Red");
            TestGetColorFromOddsNumber(-1, "", true); // Exception attendue
        }

        private void TestGetColorFromOddsNumber(int number, string expectedColor, bool shouldThrow = false)
        {
            var math = new MathOperations();
            try
            {
                var result = math.GetColorFromOddsNumber(number);
                if (shouldThrow)
                {
                    Console.WriteLine($"Test Failed for {number}: Exception was expected.");
                }
                else
                {
                    Console.WriteLine(result == expectedColor
                        ? $"Test Passed for {number}"
                        : $"Test Failed: Expected {expectedColor}, but got {result}");
                }
            }
            catch (ArgumentException ex)
            {
                if (shouldThrow)
                {
                    Console.WriteLine($"Test Passed for {number} (Exception as expected): {ex.Message}");
                }
                else
                {
                    Console.WriteLine($"Test Failed: Unexpected exception - {ex.Message}");
                }
            }
        }
    }
}

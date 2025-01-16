using System;

namespace EvaluationSampleCode
{
    class Program
    {//j'ai demandé à chatgpt pour celui là je me souvenais plus comment faire
        // mais sinon dans mes anciens commit il y a un program.cs 
        //que j'ai fais pour testé HtmlFormatHelper.
        static void Main(string[] args)
        {
            Console.WriteLine("===== Running HtmlFormatHelper Tests =====");
            var htmlTests = new HtmlFormatHelperTests();
            htmlTests.GetStrongFormat_ShouldWrapContentInStrongTags();
            htmlTests.GetItalicFormat_ShouldWrapContentInItalicTags();
            htmlTests.GetRightListFormatted_ShouldWrapContentInListTags();

            Console.WriteLine("\n===== Running MathOperations Tests =====");
            var mathTests = new MathOperationsTests();
            mathTests.SubtractTests();
            mathTests.GetColorFromOddsNumberTests();

            Console.WriteLine("\n===== Running Baptizm Tests =====");
            var baptizmTests = new BaptizmTests();
            baptizmTests.CanBeBaptizedBy_ShouldReturnTrue_ForPriest();
            baptizmTests.CanBeBaptizedBy_ShouldReturnTrue_ForPope();
            baptizmTests.CanBeTeachedBy_ShouldReturnTrue_ForAssignedClergyMember();
            baptizmTests.CanBeTeachedBy_ShouldReturnFalse_ForDifferentClergyMember();

            Console.WriteLine("\n===== All Tests Completed =====");
        }
    }
}

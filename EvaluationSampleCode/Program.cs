using System;

namespace EvaluationSampleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //test pour GetStrongFormat --

            var helper = new HtmlFormatHelper();
            var content = "Hello";

            var result = helper.GetStrongFormat(content);

            if (result == "<strong>Hello</strong>")
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine($"Test Failed: Expected '<strong>Hello</strong>' but got '{result}'");
            }
        }
    }
}

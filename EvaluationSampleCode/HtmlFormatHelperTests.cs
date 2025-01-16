using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode
{
    public class HtmlFormatHelperTests
    {
        public void GetStrongFormat_ShouldWrapContentInStrongTags()
        {
            var helper = new HtmlFormatHelper();
            var content = "Hello";
            var result = helper.GetStrongFormat(content);


            Console.WriteLine(result == "<strong>Hello</strong>" ? "Test passed" : "Test Failed");
        }

        public void GetItalicFormat_ShouldWrapContentInItalicTags()
        {
            var helper = new HtmlFormatHelper();
            var content = "Hello";
            var result = helper.GetItalicFormat(content);

            Console.WriteLine(result == "<i>World</i>" ? "Test Passed" : "Test Failed");
        }
        public void GetRightListFormatted_ShouldWrapContentInListTags()
        {
            var helper = new HtmlFormatHelper();
            var contents = new List<string> { "Item1", "Item2", "Item3" };
            var result = helper.GetFormattedListElements(contents);
            var expected = "<ul><li>Item1</li><li>Item2</li><li>Item3</li></ul>";
            Console.WriteLine(result == expected ? "Test Passed" : "Test Failed");
        }
    }
}

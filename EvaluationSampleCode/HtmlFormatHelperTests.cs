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
    }
}

using System;

namespace EvaluationSampleCode
{
    public class BaptizmTests
    {
        public void CanBeBaptizedBy_ShouldReturnTrue_ForPriest()
        {
            var priest = new ClergyMember { IsPriest = true };
            var baptizm = new Baptizm(priest);

            var result = baptizm.CanBeBaptizedBy(priest);

            Console.WriteLine(result == true ? "Test Passed" : "Test Failed");
        }

        public void CanBeBaptizedBy_ShouldReturnTrue_ForPope()
        {
            var pope = new ClergyMember { IsPope = true };
            var baptizm = new Baptizm(pope);

            var result = baptizm.CanBeBaptizedBy(pope);

            Console.WriteLine(result == true ? "Test Passed" : "Test Failed");
        }

        public void CanBeTeachedBy_ShouldReturnTrue_ForAssignedClergyMember()
        {
            var clergy = new ClergyMember { IsPriest = true };
            var baptizm = new Baptizm(clergy);

            var result = baptizm.CanBeTeachedBy(clergy);

            Console.WriteLine(result == true ? "Test Passed" : "Test Failed");
        }

        public void CanBeTeachedBy_ShouldReturnFalse_ForDifferentClergyMember()
        {
            var clergy1 = new ClergyMember { IsPriest = true };
            var clergy2 = new ClergyMember { IsPriest = true };
            var baptizm = new Baptizm(clergy1);

            var result = baptizm.CanBeTeachedBy(clergy2);

            Console.WriteLine(result == false ? "Test Passed" : "Test Failed");
        }
    }
}

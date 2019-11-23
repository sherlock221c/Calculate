using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    [TestFixtureSource(typeof(MyFixtureData), "FixtureParms")]
    public class ParameterizedTestFixture
    {
        Tools tools = new Tools();
        string s1;
        public ParameterizedTestFixture(string test, string s1)
        {
            tools.Transform(test);
            this.s1 = s1;
        }

        [Test]
        public void TestIsDecimal()
        {
            string[] sArray = tools.number.ToArray();
            string s = String.Join("", sArray);
            Console.WriteLine(s);
            Assert.AreEqual(s1, s);
        }
    }


    public class MyFixtureData
    {
        public static IEnumerable FixtureParms
        {
            get
            {
                yield return new TestFixtureData("8-(3+2×6)÷5+2^2", "8326×+5/-22^+");
                yield return new TestFixtureData("a+b×c+(d×e+f)×g", "abc×+de×f+g×+");
                yield return new TestFixtureData("4.2+23÷4×7", "4.223+÷×47");
                yield return new TestFixtureData("(3.2+4×3)÷3", "(3.24+×33÷");
            }
        }
    }
}

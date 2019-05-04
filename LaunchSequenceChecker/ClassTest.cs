using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LaunchSequenceChecker
{
    [TestFixture]
    public class ClassTest
    {
        [Test]
        public void Returnbool()
        {
            string[] input = { "stage1" };
            int[] input2 = { 5 };
            var output = LaunchSequence.launchSequenceChecker(input, input2);
            var expected = true;
            Assert.AreEqual(output, expected);
        }


        

    }
}

using MathLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTest
{
    [TestClass]
    public class MathTest
    {

        private readonly MathLogic _MathLogic;

        public MathTest()
        {
            _MathLogic = new MathLogic();
        }


        /// <summary>
        /// Test add logic
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        [TestMethod]
        [DataRow(2, 2)]
        [DataRow(1, 3)]
        [DataRow(4, 0)]
        public void IsAddTest(int value1,int value2)
        {
            
            // expected Result
            var expected = 4;

            // Actual result
            var actual = _MathLogic.Add(value1, value2);

            Assert.AreEqual<int>(expected, (int)actual);

        }


        /// <summary>
        /// Test Subtract logic
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        [TestMethod]
        [DataRow(3, 2)]
        [DataRow(4, 3)]
        [DataRow(6, 5)]
        public void Subtract(int value1, int value2)
        {

            // expected Result
            var expected = 1;

            // Actual result
            var actual = _MathLogic.Subtract(value1, value2);

            Assert.AreEqual<int>(expected, (int)actual);

        }
    }
}

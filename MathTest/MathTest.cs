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
        [DataRow(10,0 )]
        [DataRow(9, 1)]
        [DataRow(8, 2)]
        [DataRow(3, 7)]
        [DataRow(4, 6)]
        [DataRow(5, 5)]
        [DataRow(6, 4)]
        [DataRow(7, 3)]
        [DataRow(2, 8)]
        [DataRow(0, 10)]
        public void IsAddTest(int value1,int value2)
        {
            
            // expected Result
            var expected = 10;

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
        [DataRow(8, 7)]
        [DataRow(10, 9)]
        [DataRow(11, 10)]
        [DataRow(14, 13)]
        [DataRow(12, 11)]
        [DataRow(15, 14)]
        [DataRow(17, 16)]
        public void Subtract(int value1, int value2)
        {

            // expected Result
            var expected = 1;

            // Actual result
            var actual = _MathLogic.Subtract(value1, value2);

            Assert.AreEqual<int>(expected, (int)actual);

        }

        /// <summary>
        /// Test Multiply logic
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        [TestMethod]
        [DataRow(5, 4)]
        [DataRow(4, 5)]
        [DataRow(2, 10)]
        [DataRow(10, 2)]
        [DataRow(20, 1)]
        
        public void Multiply(int value1, int value2)
        {

            // expected Result
            var expected = 20;

            // Actual result
            var actual = _MathLogic.Multiply(value1, value2);

            Assert.AreEqual<int>(expected, (int)actual);

        }

        /// <summary>
        /// Test Division logic
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        [TestMethod]
        [DataRow(8, 4)]
        [DataRow(10, 5)]
        [DataRow(20, 10)]
        [DataRow(4, 2)]
        [DataRow(50, 25)]
        [DataRow(100, 50)]
        [DataRow(200, 100)]
        [DataRow(400, 200)]
        [DataRow(16, 8)]
        [DataRow(32, 16)]
        public void Division(int value1, int value2)
        {

            // expected Result
            var expected = 2;

            // Actual result
            var actual = _MathLogic.Division(value1, value2);

            Assert.AreEqual<int>(expected, (int)actual);

        }

    }
}

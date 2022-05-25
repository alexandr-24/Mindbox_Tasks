using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Square_Calculator;

namespace SquareUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Krug_10_GetSquare()
        {
            Square_Calc calc = new Square_Calc(10);

            double expected = 314.16;
            double result = Math.Round(calc.GetSquare(), 2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Radius cannot be less than or equal to 0!")]
        public void Krug_Minus10()
        {
            Square_Calc calc = new Square_Calc(-10);
        }

        [TestMethod]
        public void Krug_10_Get_isTriangleRight()
        {
            Square_Calc calc = new Square_Calc(10);
            bool result = calc.isTriangleRight();
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Triangle_2_3_4_GetSquare()
        {
            Square_Calc calc = new Square_Calc(2, 3, 4);
            double expected = 2.905;
            double result = Math.Round(calc.GetSquare(), 3);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Side cannot be less than or equal to 0!")]
        public void Triangle_2_Minus3_4()
        {
            Square_Calc calc = new Square_Calc(2, -3, 4);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Such a triangle is impossible!")]
        public void Triangle_2_3_10()
        {
            Square_Calc calc = new Square_Calc(2, 3, 10);
        }

        [TestMethod]
        public void Triangle_3_4_5_isTriangleRight()
        {
            Square_Calc calc = new Square_Calc(3, 4, 5);
            bool result = calc.isTriangleRight();
            Assert.AreEqual(true, result);
        }
    }
}

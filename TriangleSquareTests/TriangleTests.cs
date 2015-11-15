using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleSquare.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void TriangleTest()
        {
            CanTriangleExistTest();
            CanTriangleExistTest1();
            GetSquareTest();
            GetSquareTest1();
        }

        [TestMethod()]
        public void CanTriangleExistTest()
        {
            Triangle triangle = new Triangle(3,4,5);
            Assert.IsTrue(triangle.CanTriangleExist());
        }

        [TestMethod()]
        public void GetSquareTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.GetSquare());
        }

        [TestMethod()]
        public void CanTriangleExistTest1()
        {
            Triangle triangle = new Triangle(2, 3, 5);
            Assert.IsFalse(triangle.CanTriangleExist());
        }

        [TestMethod()]
        public void GetSquareTest1()
        {
            Triangle triangle = new Triangle(6, 8, 10);
            Assert.AreNotEqual(23, triangle.GetSquare());
        }
    }
}
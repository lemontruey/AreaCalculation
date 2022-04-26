namespace Unit
{
    using HomeExercise;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void CalculateTest()
        {
            Assert.AreEqual(Calculate.GetSquare(1, 2, 3),    0);
            Assert.AreEqual(Calculate.GetSquare(0, 1, 12),   0);
            Assert.AreEqual(Calculate.GetSquare(5, 4, 3),    6);
            Assert.AreEqual(Calculate.GetSquare(3, 4, 5),    6);
            Assert.AreEqual(Calculate.GetSquare(12, 12, 12), 62.35383);
        }
    }
}
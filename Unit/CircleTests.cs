namespace Unit
{
    using HomeExercise;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CalculateTest()
        {
            Assert.AreEqual(Calculate.GetSquare(2.3), 16.61903);
            Assert.AreEqual(Calculate.GetSquare(10),  314.15927);
            Assert.AreEqual(Calculate.GetSquare(0),   0);
            Assert.AreEqual(Calculate.GetSquare(-1),  0);
        }
    }
}
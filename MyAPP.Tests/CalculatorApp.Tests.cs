using NUnit.Framework;

namespace CalculatorApp.Tests
{
    [TestFixture]
    internal class CalculatorTests
    {
        [TestCase(2, 3, 5)]
        [TestCase(10, -4, 6)]
        [TestCase(0, 0, 0)]
        [TestCase(-3, -7, -10)]
        public void Add_TwoInteger_ReturnResult(int num, int addNum, int expect)
        {
            // Arrange（安排情境）
            var calc = new MyAPP.Calculator();
            // Act（執行行為）
            int result = calc.Add(num, addNum);
            // Assert（驗證結果）
            Assert.AreEqual(expect, result);
        }
    }
}

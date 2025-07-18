using MyAPP;
using NUnit.Framework;

namespace CalculatorApp.Tests
{
    [TestFixture]
    internal class CalculatorTests
    {
        #region 加法測試
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

        [Test]
        public void Add_ResultOverflow_ThrowOverflowException()
        {
            // Arrange（安排情境）
            var calc = new Calculator();
            // Act（執行行為）
            var ex = Assert.Throws<OverflowException>(() => calc.Add(int.MaxValue, 1));
            // Assert（驗證結果）
            //Assert.That(ex.Message, Is.EqualTo("加總超過 int.MaxValue"));
        }
        #endregion

        #region 減法測試
        [TestCase(2, 3, -1)]
        [TestCase(10, -4, 14)]
        [TestCase(0, 0, 0)]
        [TestCase(-3, -7, 4)]
        public void Sub_TwoInteger_ReturnResult(int num, int subNum, int expect)
        {
            // Arrange（安排情境）
            var calc = new MyAPP.Calculator();
            // Act（執行行為）
            int result = calc.Subtract(num, subNum);
            // Assert（驗證結果）
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void Sub_ResultOverflow_ThrowOverflowException()
        {
            // Arrange（安排情境）
            var calc = new Calculator();
            // Act（執行行為）
            var ex = Assert.Throws<OverflowException>(() => calc.Subtract(int.MaxValue, -1));
            // Assert（驗證結果）
            //Assert.That(ex.Message, Is.EqualTo("減法結果超過 int.MaxValue 或小於 int.MinValue"));
        }
        #endregion

        #region 乘法測試
        [TestCase(2, 3, 6)]
        [TestCase(10, -4, -40)]
        [TestCase(0, 0, 0)]
        [TestCase(-3, -7, 21)]
        public void Mul_TwoInteger_ReturnResult(int num, int mulNum, int expect)
        {
            // Arrange（安排情境）
            var calc = new MyAPP.Calculator();
            // Act（執行行為）
            int result = calc.Multiply(num, mulNum);
            // Assert（驗證結果）
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void Mul_ResultOverflow_ThrowOverflowException()
        {
            // Arrange（安排情境）
            var calc = new Calculator();
            // Act（執行行為）
            var ex = Assert.Throws<OverflowException>(() => calc.Multiply(int.MaxValue, 2));
            // Assert（驗證結果）
            //Assert.That(ex.Message, Is.EqualTo("乘法結果超過 int.MaxValue 或小於 int.MinValue"));
        }
        #endregion

        #region 除法測試
        [TestCase(6, 3, 2)]
        [TestCase(10, -2, -5)]
        [TestCase(0, 1, 0)]
        [TestCase(-6, -3, 2)]
        public void Div_TwoInteger_ReturnResult(int num, int divNum, int expect)
        {
            // Arrange（安排情境）
            var calc = new MyAPP.Calculator();
            // Act（執行行為）
            int result = calc.Divide(num, divNum);
            // Assert（驗證結果）
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void Div_DivideByZero_ThrowDivideByZeroException()
        {
            // Arrange（安排情境）
            var calc = new Calculator();
            // Act（執行行為）
            var ex = Assert.Throws<DivideByZeroException>(() => calc.Divide(10, 0));
            // Assert（驗證結果）
            //Assert.That(ex.Message, Is.EqualTo("除數不能為零"));
        }

        [Test]
        public void Div_ResultOverflow_ThrowOverflowException()
        {
            // Arrange（安排情境）
            var calc = new Calculator();
            // Act（執行行為）
            var ex = Assert.Throws<OverflowException>(() => calc.Divide(int.MinValue, -1));
            // Assert（驗證結果）
            //Assert.That(ex.Message, Is.EqualTo("除法結果超過 int.MaxValue 或小於 int.MinValue"));
        }
        #endregion
    }
}

using MyTestLibrary;


namespace MyCalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = 10;
            double b = 20;

            // Act
            double result = calculator.Add(a, b);

            // Assert
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void Subtract_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = 20;
            double b = 10;

            // Act
            double result = calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Multiply_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = 10;
            double b = 5;

            // Act
            double result = calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void Divide_ReturnsCorrectResult()
        {

            // Arrange
            var calculator = new Calculator();
            double a = 10;
            double b = 2;

            // Act
            double result = calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Divide_Zero()
        {

            // Arrange
            var calculator = new Calculator();
            double a = 10;
            double b = 2;

            // Act
            double result = calculator.Divide(a, b);

            // Assert
            Assert.AreNotEqual(0, result);
        }

        [TestMethod]
        public void Add_LargeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = 10;
            double b = 20;
            double c = double.MaxValue;

            // Act
            double result = calculator.Add(a, b);

            // Assert
            Assert.IsFalse(result > c);
        }

        [TestMethod]
        public void Divide_SmallNumbers_ReturnsCorrectResult()
        {

            // Arrange
            var calculator = new Calculator();
            double a = 10;
            double b = 2;
            double c = double.MinValue;

            // Act
            double result = calculator.Divide(a, b);

            // Assert
            Assert.IsTrue(result > c);
        }

        [TestMethod]
        public void Subtract_NegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = 20;
            double b = 10;

            // Act
            double result = calculator.Subtract(a, b);

            // Assert
            Assert.IsTrue(a > 0 && b > 0);
        }

        [TestMethod]
        public void Multiply_MixedSignNumbers_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = -10;
            double b = 5;

            // Act
            double result = calculator.Multiply(a, b);

            // Assert
            Assert.IsTrue(result == -50);
            
        }
    }
}

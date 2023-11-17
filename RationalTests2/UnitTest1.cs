using Rational2;

namespace RationalTests2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            
            Rational rational1 = new Rational(1, 3);
            Rational rational2 = new Rational(1, 4);

            Rational result = rational1 + (rational2);

            Assert.AreEqual(7, result.GetNumerator());
            Assert.AreEqual(12, result.GetDenominator());
        }
        [TestMethod()]
        public void AddTest_GG()
        {
            Rational rational1 = new Rational(1, 6);
            Rational rational2 = new Rational(1, 3);

            Rational result = rational1 + (rational2);

            Assert.AreEqual(1, result.GetNumerator());
            Assert.AreEqual(2, result.GetDenominator());
        }

        [TestMethod()]
        public void Multiply_GG()
        {
            Rational rational1 = new Rational(1, 2);
            Rational rational2 = new Rational(3, 2);

            Rational result = rational1 * (rational2);

            Assert.AreEqual(3, result.GetNumerator());
            Assert.AreEqual(4, result.GetDenominator());
        }

        [TestMethod()]
        public void Multiply_G()
        {
            Rational rational1 = new Rational(1, 3);
            Rational rational2 = new Rational(2, 5);

            Rational result = rational1 * (rational2);

            Assert.AreEqual(2, result.GetNumerator());
            Assert.AreEqual(15, result.GetDenominator());
        }

        [TestMethod()]
        public void Multiply_GGG()
        {
            Rational rational1 = new Rational(2, 3);
            Rational rational2 = new Rational(3, 4);

            Rational result = rational1 * (rational2);

            Assert.AreEqual(1, result.GetNumerator());
            Assert.AreEqual(2, result.GetDenominator());
        }

        [TestMethod()]
        public void Sub_GG()
        {
            Rational rational1 = new Rational(3, 5);
            Rational rational2 = new Rational(1, 3);

            Rational result = rational1 - (rational2);

            Assert.AreEqual(4, result.GetNumerator());
            Assert.AreEqual(15, result.GetDenominator());
        }

        [TestMethod()]
        public void Sub_GGG()
        {
            Rational rational1 = new Rational(7, 9);
            Rational rational2 = new Rational(2, 3);

            Rational result = rational1 - (rational2);

            Assert.AreEqual(1, result.GetNumerator());
            Assert.AreEqual(9, result.GetDenominator());
        }

        [TestMethod()]
        public void Divide_G()
        {
            Rational rational1 = new Rational(1, 2);
            Rational rational2 = new Rational(3, 2);

            Rational result = rational1 / (rational2);

            Assert.AreEqual(1, result.GetNumerator());
            Assert.AreEqual(3, result.GetDenominator());
        }

        [TestMethod()]
        public void Divide_GG()
        {
            Rational rational1 = new Rational(1, 3);
            Rational rational2 = new Rational(2, 5);

            Rational result = rational1 / (rational2);

            Assert.AreEqual(5, result.GetNumerator());
            Assert.AreEqual(6, result.GetDenominator());
        }

        [TestMethod()]
        public void Divide_GGG()
        {
            Rational rational1 = new Rational(2, 3);
            Rational rational2 = new Rational(3, 4);

            Rational result = rational1 / (rational2);

            Assert.AreEqual(8, result.GetNumerator());
            Assert.AreEqual(9, result.GetDenominator());
        }
    }
}
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromic_prime;

namespace Palindromic_primeTests
{
    [TestClass()]
    public class PalinDromicPrimeTests
    {
        #region PalinDromicPrime Tests
        [TestMethod(), TestCategory("Unit")]
        public void PalinDromePrime_Decimal_NumberOf_ShouldBeFive()
        {
            // Arrange
            var test = PalinDromicPrime.PalinDromePrime(1, 100, 10);
            test.Should().HaveCount(5);
        }

        [TestMethod(), TestCategory("Unit")]
        public void PalinDromePrime_Binary_NumberOf_ShouldBeSix()
        {
            // Arrange
            var test = PalinDromicPrime.PalinDromePrime(1, 100, 2);
            test.Should().HaveCount(6);
        }

        [TestMethod(), TestCategory("Unit")]
        public void PalinDromePrime_Hexa_NumberOf_ShouldBeSix()
        {
            // Arrange
            var test = PalinDromicPrime.PalinDromePrime(1, 100, 2);
            test.Should().HaveCount(6);
        }

        [TestMethod(), TestCategory("Unit")]
        public void PalinDromePrime_Octal_NumberOf_ShouldBeSix()
        {
            // Arrange
            var test = PalinDromicPrime.PalinDromePrime(1, 100, 2);
            test.Should().HaveCount(6);
        }

        #endregion

        #region IsPrime tests
        [TestMethod(), TestCategory("Unit")]
        public void IsPrime_WithPrime_ShouldBeTrue()
        {
            // Arrange
            var test = PalinDromicPrime.IsPrime(11);

            // Assert
            test.Should().BeTrue();
        }

        [TestMethod(), TestCategory("Unit")]
        public void IsPrime_WithNonPrime_ShouldBeFalse()
        {
            // Arrange
            var test = PalinDromicPrime.IsPrime(12);

            // Assert
            test.Should().BeFalse();
        }
        #endregion

        #region IsPalinDromic Tests
        [TestMethod(), TestCategory("Unit")]
        public void IsPalinDromic_WithPalinDromic_ShouldBeTrue()
        {
            // Arrange
            var test = PalinDromicPrime.IsPalinDrome(393);

            // Assert
            test.Should().BeTrue();
        }

        [TestMethod(), TestCategory("Unit")]
        public void IsPalinDromoc_WithNonPalinDromoc_ShouldBeFalse()
        {
            // Arrange
            var test = PalinDromicPrime.IsPalinDrome(120);

            // Assert
            test.Should().BeFalse();
        }

        [TestMethod(), TestCategory("Unit")]
        public void IsPalinDromic_Binary_WithPalinDromic_ShouldBeTrue()
        {
            // Arrange
            var test = PalinDromicPrime.IsPalinDrome(17, 2);

            // Assert
            test.Should().BeTrue();
        }

        [TestMethod(), TestCategory("Unit")]
        public void IsPalinDromoc_Binary_WithNonPalinDromoc_ShouldBeFalse()
        {
            // Arrange
            var test = PalinDromicPrime.IsPalinDrome(120, 2);

            // Assert
            test.Should().BeFalse();
        }
        [TestMethod(), TestCategory("Unit")]
        public void IsPalinDromic_Octal_WithPalinDromic_ShouldBeTrue()
        {
            // Arrange
            var test = PalinDromicPrime.IsPalinDrome(373, 8);

            // Assert
            test.Should().BeTrue();
        }

        [TestMethod(), TestCategory("Unit")]
        public void IsPalinDromoc_Octal_WithNonPalinDromoc_ShouldBeFalse()
        {
            // Arrange
            var test = PalinDromicPrime.IsPalinDrome(220, 8);

            // Assert
            test.Should().BeFalse();
        }
        [TestMethod(), TestCategory("Unit")]
        public void IsPalinDromic_Hexa_WithPalinDromic_ShouldBeTrue()
        {
            // Arrange
            var test = PalinDromicPrime.IsPalinDrome(433, 16);

            // Assert
            test.Should().BeTrue();
        }

        [TestMethod(), TestCategory("Unit")]
        public void IsPalinDromoc_Hexa_WithNonPalinDromoc_ShouldBeFalse()
        {
            // Arrange
            var test = PalinDromicPrime.IsPalinDrome(121, 16);

            // Assert
            test.Should().BeFalse();
        }

        //TODO: Tests with Octal and Hexa
        #endregion
    }
}
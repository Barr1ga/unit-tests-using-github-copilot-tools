namespace System.Numbers.UnitTests
{
    public class PrimeServiceTests
    {
        private readonly PrimeService _primeService = new PrimeService();

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_InputLessThan2_ReturnsFalse(int value)
        {
            Assert.False(_primeService.IsPrime(value));
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsPrime_InputIsPrime_ReturnsTrue(int value)
        {
            Assert.True(_primeService.IsPrime(value));
        }

        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        public void IsPrime_InputIsNotPrime_ReturnsFalse(int value)
        {
            Assert.False(_primeService.IsPrime(value));
        }

        [Fact]
        public void IsPrime_LargePrimeNumber_ReturnsTrue()
        {
            Assert.True(_primeService.IsPrime(7919)); // Example of a large prime number
        }

        [Fact]
        public void IsPrime_LargeNonPrimeNumber_ReturnsFalse()
        {
            Assert.False(_primeService.IsPrime(8000)); // Example of a large non-prime number
        }
    }
}

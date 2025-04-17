namespace System.Numbers.UnitTests
{
    public class PrimeServiceTests
    {
        private readonly PrimeService _primeService;

        public PrimeServiceTests()
        {
            _primeService = new PrimeService();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_InputLessThan2_ReturnsFalse(int value)
        {
            // Act
            var result = _primeService.IsPrime(value);

            // Assert
            Assert.False(result, $"{value} should not be prime.");
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsPrime_InputIsPrime_ReturnsTrue(int value)
        {
            // Act
            var result = _primeService.IsPrime(value);

            // Assert
            Assert.True(result, $"{value} should be prime.");
        }

        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        public void IsPrime_InputIsNotPrime_ReturnsFalse(int value)
        {
            // Act
            var result = _primeService.IsPrime(value);

            // Assert
            Assert.False(result, $"{value} should not be prime.");
        }
    }
}

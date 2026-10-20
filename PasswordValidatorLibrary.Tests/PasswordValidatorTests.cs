namespace PasswordValidatorLibrary.Tests
{
    public class PasswordValidatorTests
    {
        [Fact]
        public void Validate_ValidPassword_ReturnsTrue()
        {
            string password = "Password1";

            bool result = PasswordValidator.Validate(password);

            Assert.True(result);
        }

        [Fact]
        public void Validate_TooShortPassword_ReturnsFalse()
        {
            string password = "qwe1";

            bool result = PasswordValidator.Validate(password);

            Assert.False(result);
        }

        [Fact]
        public void Validate_PasswordWithoutDigit_ReturnsFalse()
        {
            string password = "qwertyuio";

            bool result = PasswordValidator.Validate(password);

            Assert.False(result);
        }

        [Fact]
        public void Validate_PasswordWithoutLatinLetter_ReturnsFalse()
        {
            string password = "123456789";

            bool result = PasswordValidator.Validate(password);

            Assert.False(result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Validate_NullOrEmptyPassword_ReturnsFalse(string? password)
        {
            bool result = PasswordValidator.Validate(password);

            Assert.False(result);
        }
    }
}

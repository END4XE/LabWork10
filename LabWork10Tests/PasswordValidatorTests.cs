using LabWork10;

namespace LabWork10Tests
{
    public class PasswordValidatorTests
    {
        #region Позитивные тесты

        [Theory]
        [InlineData("Password123")]
        [InlineData("a1234567")]
        [InlineData("123456a")]
        [InlineData("P@ssword1!")]
        [InlineData("VerylongPassword1234")]
        public void IsValid_ValidPassword_ReturnsTrue(string password)
        {
            bool result = PasswordValidator.IsValid(password);

            Assert.True(result);
        }

        #endregion

        #region Негативные тесты  

        [Theory]
        [InlineData("Pass1")]
        [InlineData("1234567")]
        [InlineData("abvgdefj")]
        [InlineData("12345678")]
        [InlineData("Пароль123")]
        [InlineData("!@#%$^&*()")]
        [InlineData("")]
        [InlineData(null)]
        public void IsValid_InvalidPassword_ReturnsFalse(string password)
        {
            bool result = PasswordValidator.IsValid(password);

            Assert.False(result);
        }

        #endregion
    }
}

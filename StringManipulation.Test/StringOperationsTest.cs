using Microsoft.Extensions.Logging;
using Moq;

namespace StringManipulation.Test
{
    public class StringOperationsTest
    {
        [Fact]
        public void ConcatenateStrings()
        {
            //Arrange
            var strOperations = new StringOperations();

            //Act
            var result = strOperations.ConcatenateStrings("Hello", "Platzi");

            //Assert
            //primero lo esperado y luego lo que retorna{
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("Hello Platzi", result);
        }
        [Fact]
        public void IsPalindrome_True()
        {
            //Arrange
            var strOperations = new StringOperations();
            //Act
            var result = strOperations.IsPalindrome("Ama"); //Se puede leer de igual forma izq a derecha y derecha a izquierda
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_False()
        {
            //Arrange
            var strOperations = new StringOperations();
            //Act
            var result = strOperations.IsPalindrome("Juan Pablo"); //Se puede leer de igual forma izq a derecha y derecha a izquierda
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void RemoveWhitespace()
        {
            //Arrange
            var strOperations = new StringOperations();
            //Act
            var result = strOperations.RemoveWhitespace("Juan Pablo"); //Remover espacio en blanco
            //Assert
            Assert.Equal("JuanPablo", result);
        }

        [Fact]
        public void QuantintyInWords()
        {
            var strOperations = new StringOperations();
            var result = strOperations.QuantintyInWords("Balloon", 1000);
            Assert.StartsWith("mil", result);
            Assert.Contains("Balloon", result);
        }

        [Fact]
        public void GetStringLenth_Exception()
        {
            var strOperations = new StringOperations();
            Assert.ThrowsAny<ArgumentNullException>(() => strOperations.GetStringLength(null));
        }

        [Fact]
        public void GetStringLength_NoException()
        {
            var strOperations = new StringOperations();

            var exception = Record.Exception(() => strOperations.GetStringLength("Hola"));

            Assert.Null(exception);
        }

        [Theory]
        [InlineData("V", 5)]
        [InlineData("III", 3)]
        [InlineData("X", 10)]
        public void FromRomanToNumber(string romanNumber, int expected)
        {
            var strOperations = new StringOperations();

            var result = strOperations.FromRomanToNumber(romanNumber);

            Assert.Equal(expected, result);
        }

        //Skip

        [Fact(Skip = "Esta prueba no es valida en este momento")]
        public void ConcatenateStringsSkip()
        {
            //Arrange
            var strOperations = new StringOperations();

            //Act
            var result = strOperations.ConcatenateStrings("Hello", "Platzi");

            //Assert
            //primero lo esperado y luego lo que retorna{
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("Hello Platzi", result);
        }

        [Fact]
        public void CountOccurrences()
        {
            //Arrange

            //aqui se utiliza la libreria Moq
            var mockLogger = new Mock<ILogger<StringOperations>>();

            var strOperations = new StringOperations(mockLogger.Object);




            //Act
            var result = strOperations.CountOccurrences("Platzi", 'i');
            //Assert
            Assert.Equal(1, result);
        }

    }
}

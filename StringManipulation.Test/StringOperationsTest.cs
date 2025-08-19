using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

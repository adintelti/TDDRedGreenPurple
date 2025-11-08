namespace PrjTDDRedGreenPurple.Test
{
    public class NumeroHelperTests
    {
        [Fact]
        public void NumeroHelper_DeveRetornarTrueQuandoNumeroForPar()
        {
            // Arrange
            int numero = 4;

            // Act
            bool resultado = NumeroHelper.EhPar(numero);

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void NumeroHelper2_DeveRetornarTrueQuandoNumeroForPar()
        {
            // Arrange
            int numero = 4;

            // Act
            bool resultado = NumeroHelper2.EhPar(numero);

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void DeveRetornarFalseQuandoNumeroForImpar()
        {
            // Arrange
            int numero = 5;

            // Act
            bool resultado = NumeroHelper2.EhPar(numero);

            // Assert
            Assert.False(resultado);
        }

        [Fact]
        public void DeveRetornarTrueQuandoNumeroForImpar()
        {
            int numero = 7;
            bool resultado = NumeroHelper2.EhImpar(numero);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(2, true)]
        [InlineData(4, true)]
        [InlineData(6, true)]
        [InlineData(5, false)]
        [InlineData(7, false)]
        [InlineData(9, false)]
        public void DeveValidarSeNumeroEhPar(int numero, bool esperado)
        {
            // Act
            bool resultado = NumeroHelper2.EhPar(numero);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(3, true)]
        [InlineData(5, true)]
        [InlineData(2, false)]
        [InlineData(4, false)]
        [InlineData(8, false)]
        public void DeveValidarSeNumeroEhImpar(int numero, bool esperado)
        {
            // Act
            bool resultado = NumeroHelper2.EhImpar(numero);

            // Assert
            Assert.Equal(esperado, resultado);
        }

    }
}

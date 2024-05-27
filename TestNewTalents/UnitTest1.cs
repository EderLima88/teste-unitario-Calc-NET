using NewTalents;

namespace TestNewTalents
{
    public class UnitTest1
    {
        [Fact]
        public void SomarTeste()
        {
            Calculadora calc = new Calculadora();
            int res = calc.Somar(2,1);
            Assert.Equal(3, res);
        }
        [Fact]
        public void SubtrairTeste()
        {
            Calculadora calc = new Calculadora();
            int res = calc.Subtrair(2,1);
            Assert.Equal(1, res);
        }

        [Fact]
        public void MultiplicarTeste()
        {
            Calculadora calc = new Calculadora();
            int res = calc.Multiplicar(2, 1);
            Assert.Equal(2, res);
        }

        [Fact]
        public void DividirTeste()
        {
            Calculadora calc = new Calculadora();
            //int res = calc.Dividir(2, 1);
            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0)
                );
        }

        [Fact]
        public void HistoricoTeste() 
        {
            Calculadora calc = new Calculadora();
            calc.Somar(1, 2);
            calc.Somar(2, 2);
            calc.Somar(3, 2);
            calc.Somar(4, 2);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);   

        }

    }
}
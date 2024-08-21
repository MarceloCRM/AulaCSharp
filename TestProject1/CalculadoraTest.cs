using AulasPOO.uteis;

namespace TestProject1
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void SomaTest()
        {
            //Cenário
            var calc = new Calculadora();
            int num1 = 20;
            int num2 = 22;
            int resultado;
            //Ação
            resultado = calc.Soma(num1, num2);
            //Teste
            Assert.AreEqual(42, resultado);
        }

        [TestMethod]
        public void MultiplicaTest()
        {
            int num1 = 20;
            int num2 = 2;
            int resultado;
            resultado = Calculadora.Multiplica(num1, num2);
            Assert.AreEqual(40, resultado);
        }

        [TestMethod]

        public void FatorialTest()
        {
            int num = 5;
            int resultado;
            resultado = Calculadora.Fatorial(num);
            Assert.AreEqual(120, resultado);
        }

        [TestMethod]

        public void ImcTest()
        {
            float peso = 87.5f;
            float altura = 1.8f;
            float imc;
            imc = Calculadora.IMC(peso, altura);
            Assert.AreEqual(27.01, Math.Round(imc, 2));
        }
    }
}
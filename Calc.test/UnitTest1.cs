using SistemaHotel.Controller;


namespace Calc.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()

        {
            
            var calPagamento = new CalPagamento();
            int dias = 5;
            double valorQuarto = 100;
            double expected = 500;

           
            double result = calPagamento.CalcPagamento(dias, valorQuarto);

            
            Assert.Equal(expected, result);
        }
            
    }

}

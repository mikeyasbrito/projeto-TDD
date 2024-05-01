using Calculadora.Services;
namespace CalculadoraTeste;

public class CalculadoraTeste
{
    private CalculadoraImp _calc;

    public CalculadoraTeste()
    {
        _calc = new CalculadoraImp();
    }

    [Theory]
    [InlineData(10, 20, 30)]
    public void TesteSoma(int val1, int val2, int resultado)
    {
        //arrange

        //act
        int resultadoDaCalculadora = _calc.Sum(val1, val2);

        //Assert
        Assert.Equal(resultadoDaCalculadora, resultado);
    }

     [Theory]
    [InlineData(10, 20, 30)]
    public void TesteSub(int val1, int val2, int resultado)
    {
        //arrange

        //act
        int resultadoDaCalculadora = _calc.Sub(val1, val2);

        //Assert
        Assert.Equal(resultadoDaCalculadora, resultado);
    }

     [Theory]
    [InlineData(5, 5, 25)]
    public void TesteMult(int val1, int val2, int resultado)
    {
        //arrange

        //act
        int resultadoDaCalculadora = _calc.Mult(val1, val2);

        //Assert
        Assert.Equal(resultadoDaCalculadora, resultado);
    }

     [Theory]
    [InlineData(5, 20, 4)]
    public void TesteDiv(int val1, int val2, int resultado)
    {
        //arrange

        //act
        int resultadoDaCalculadora = _calc.Div(val1, val2);

        //Assert
        Assert.Equal(resultadoDaCalculadora, resultado);
    }
}
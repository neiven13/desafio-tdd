using Xunit;
using desafio_tdd;

namespace Tests;

public class CalculadoraImplTest
{
    private readonly CalculadoraImpl _calculadora;

    public CalculadoraImplTest()
    {
        _calculadora = new CalculadoraImpl();
    }

    [Fact]
    public void Somar_DeveRetornarSoma()
    {
        double resultado = _calculadora.Somar(2, 3);
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void Subtrair_DeveRetornarDiferenca()
    {
        double resultado = _calculadora.Subtrair(5, 3);
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void Dividir_DeveRetornarQuociente()
    {
        double resultado = _calculadora.Dividir(6, 2);
        Assert.Equal(3, resultado);
    }

    [Fact]
    public void Dividir_DivisaoPorZero_DeveLancarExcecao()
    {
        Assert.Throws<Exception>(() => _calculadora.Dividir(6, 0));
    }

    [Fact]
    public void Multiplicar_DeveRetornarProduto()
    {
        double resultado = _calculadora.Multiplicar(2, 3);
        Assert.Equal(6, resultado);
    }
}
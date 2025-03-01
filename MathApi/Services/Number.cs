namespace MathApi.Services;

public class Number
{
    /// <summary>
    /// Soma dois números inteiros.
    /// </summary>
    /// <param name="a">O primeiro número inteiro.</param>
    /// <param name="b">O segundo número inteiro.</param>
    /// <returns>O resultado da soma como um número inteiro.</returns>
    public int Sum(int a, int b)
    {
        return a + b;
    }


    /// <summary>
    /// Divide dois números inteiros.
    /// </summary>
    /// <param name="a">O numerador (número a ser dividido).</param>
    /// <param name="b">O denominador (divisor).</param>
    /// <returns>O resultado da divisão como um número de ponto flutuante.</returns>
    /// <exception cref="DivideByZeroException">Lançada quando o denominador é zero.</exception>
    public float Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Divisão por zero não é permitida.");
        }

        return (float)a / b; 
    }
}
namespace MathApi.Services;

public class Numbers
{
    private readonly Number _number = new Number();

    /// <summary>
    /// Soma todos os números em uma lista de inteiros.
    /// </summary>
    /// <param name="numbers">Um array de números inteiros.</param>
    /// <returns>O resultado da soma como um número inteiro.</returns>
    /// <remarks>
    /// Se a lista for nula ou vazia, o método retornará 0.
    /// Se ocorrer overflow, uma exceção <see cref="OverflowException"/> será lançada.
    /// </remarks>
    public int Sum(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return 0;

        try
        {
            // Usa "checked" para detectar overflow
            checked
            {
                int sum = 0;
                foreach (int num in numbers)
                {
                    sum += num;
                }
                return sum;
            }
        }
        catch (OverflowException)
        {
            throw new OverflowException("A soma dos números excede o limite de um inteiro (int).");
        }
    }

    /// <summary>
    /// Calcula a média aritmética de uma lista de números inteiros.
    /// </summary>
    /// <param name="numbers">Um array de números inteiros.</param>
    /// <returns>O resultado da média como um número de ponto flutuante.</returns>
    /// <exception cref="ArgumentException">Lançada quando a lista é nula ou vazia.</exception>
    public float Average(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("A lista de números não pode ser vazia ou nula.");
        }

        int sum = Sum(numbers); // Usa o método Sum corrigido
        return (float)sum / numbers.Length; // Calcula a média manualmente
    }
}
using MathApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace MathApi.Controllers;

[ApiController]
[Route("math")]
public class MathController : ControllerBase
{
    private readonly Numbers _mathOperations = new();

    /// <summary>
    /// Soma uma lista de números inteiros.
    /// </summary>
    /// <param name="numbers">Lista de números inteiros.</param>
    /// <returns>Resultado da soma.</returns>
    /// <response code="200">Retorna o resultado da soma.</response>
    [HttpPost("sum")]
    public IActionResult Sum([FromBody] int[] numbers)
    {
        try
        {
            return Ok(new { result = _mathOperations.Sum(numbers) });
        }
        catch (OverflowException ex)
        {
            return BadRequest(new { error = ex.Message });
        }
    }

    /// <summary>
    /// Calcula a média aritmética de uma lista de números inteiros.
    /// </summary>
    /// <param name="numbers">Lista de números inteiros.</param>
    /// <returns>Resultado da média.</returns>
    /// <response code="200">Retorna o resultado da média.</response>
    /// <response code="400">Retorna um erro se a lista for vazia ou nula.</response>
    [HttpPost("average")]
    public IActionResult Average([FromBody] List<int> numbers)
    {
        int[] numbersArray = numbers?.ToArray() ?? Array.Empty<int>();
        try
        {
            return Ok(new { result = _mathOperations.Average(numbersArray) });
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { error = ex.Message });
        }
    }
}
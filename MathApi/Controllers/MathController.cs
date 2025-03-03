using MathApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace MathApi.Controllers;

[ApiController]
[Route("math")]
public class MathController : ControllerBase
{
    private readonly Numbers _mathOperations;

    public MathController(Numbers mathOperations)
    {
        _mathOperations = mathOperations;
    }


    /// <summary>
    /// Soma uma lista de números inteiros.
    /// </summary>
    /// <param name="numbers">Lista de números inteiros.</param>
    /// <returns>Resultado da soma.</returns>
    /// <response code="200">Retorna o resultado da soma.</response>
    /// <response code="400">Retorna erro se a soma causar overflow.</response>
    [HttpPost("operations/sum")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Dictionary<string, int>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Dictionary<string, string>))]
    public IActionResult Sum([FromBody] int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return BadRequest(new { error = "A lista de números não pode ser vazia ou nula." });
        }

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
    /// <response code="200">Retorna a média.</response>
    /// <response code="400">Retorna erro se a lista for vazia ou nula.</response>
    [HttpGet("operations/average")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Dictionary<string, float>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Dictionary<string, string>))]
    public IActionResult Average([FromQuery] int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return BadRequest(new { error = "A lista de números não pode ser vazia ou nula." });
        }

        try
        {
            return Ok(new { result = _mathOperations.Average(numbers) });
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { error = ex.Message });
        }
    }

}
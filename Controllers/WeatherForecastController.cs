using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ContosoPizza.Controllers 
{
    [ApiController]
    // [ApiController] habilita comportamentos dogmáticos que facilitam a criação de APIs Web. Alguns comportamentos incluem inferência de fonte de parâmetro, roteamento de atributo como um requisito e aprimoramentos de tratamento de erro de validação de modelo.

    [Route("[controller]")]
    // [Route] define o padrão de roteamento [controller]. O token [controller] é substituído pelo nome do controlador
    
    public class WeatherForecastController : ControllerBase // Nossa classe base herda da classe ControllerBase que fornece diversas            funcionalidades padrão para manipular solicitação HTTP
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}

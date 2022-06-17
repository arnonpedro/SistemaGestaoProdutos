using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaGestaoProdutos.Domain.Entities;
using SistemaGestaoProdutos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGestaoProdutos.Ui.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IProdutoService produtoService)
        {
            _logger = logger;
            
        }


    }
}

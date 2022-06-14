using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlockbuster.Services;
using MyBlockbuster.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaLocadora.Controllers
{
    [Route("serie")]
    [ApiController]
    public class SerieController : ControllerBase
    {
        public SerieServices _service = new SerieServices();

        [HttpPost]
        public IActionResult RegistersMovie(SerieViewModels series)
        {
            if (series == null)
            {
                return BadRequest("Please! Register a serie.");
            }

            SerieViewModels serie = _service.RegisterSeries(series);

            return Created("series", serie);
        }
    }
}

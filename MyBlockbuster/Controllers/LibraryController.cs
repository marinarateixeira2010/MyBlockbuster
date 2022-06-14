using Microsoft.AspNetCore.Mvc;
using MyBlockbuster.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlockbuster.Controllers
{
    [Route("library")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        public LibraryServices _service = new LibraryServices();

        [HttpGet]
        public IActionResult ListsLibrary()
        {
            List<object> itens = _service.ListsItens();

            return Ok(itens);
        }
    }
}

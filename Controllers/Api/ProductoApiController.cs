using Microsoft.AspNetCore.Mvc;
using ProyectoBaseAspNet.Models;
using System.Collections.Generic;
using ProyectoBaseAspNet.Models;
using Microsoft.AspNetCore.Mvc;


namespace ProyectoBaseAspNet.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoApiController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new List<Producto> {
                new Producto { Id = 1, Nombre = "Mouse", Precio = 25 },
                new Producto { Id = 2, Nombre = "Teclado", Precio = 40 }
            });
        }
    }
}
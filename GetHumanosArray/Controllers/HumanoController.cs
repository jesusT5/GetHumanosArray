using GetHumanoArray.Model;
using Microsoft.AspNetCore.Mvc;

namespace GetHumanoArray.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HumanoController : ControllerBase
    {
        // GET: HumanoController
        [HttpGet]
        public Humano[] Index()
        {
            Humano[] humanos = {
                new Humano(1, "Juan", "Masculino", 20, 1.60M, 70.60M) ,
                new Humano(1, "Andres", "Masculino", 30, 1.70M, 80.5M) ,
                new Humano(1, "Pedro", "Masculino", 25, 1.80M, 90) ,
                new Humano(1, "Gustavo", "Masculino", 35, 1.60M, 85) ,
                new Humano(1, "Pavel", "Masculino", 38, 1.65M, 63) ,
                new Humano(1, "Carol", "Femenino", 25, 1.75M, 65) ,
                new Humano(1, "Grecia", "Femenino", 26, 1.68M, 68) ,
            };
            return humanos;
        }
    }
}

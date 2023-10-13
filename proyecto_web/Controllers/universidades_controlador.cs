using Microsoft.AspNetCore.Mvc;
using proyecto_web.context;
using proyecto_web.modelos;

namespace proyecto_web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class universidaes_controlador : ControllerBase
    {

        private readonly ILogger<universidaes_controlador> _logger;
        private readonly app_contexto _app_contexto;
        public universidaes_controlador(
            ILogger<universidaes_controlador> logger,
            app_contexto app_contexto)
        {
            _logger = logger;
            _app_contexto = app_contexto;
        }
        //Create
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] universidad universidad)
        {
            _app_contexto.universidades.Add(universidad);
            _app_contexto.SaveChanges();
            return Ok(universidad);
        }
        //READ: 
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_app_contexto.universidades.ToList());

        }
        //Update:
        [Route("{id}")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] universidad universidad)
        {
            _app_contexto.universidades.Update(universidad);
            _app_contexto.SaveChanges();
            return Ok(universidad);
        }
        //Delete: 
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int idUniversidad)
        {
            _app_contexto.universidades.Remove(
                _app_contexto.universidades.ToList()
                .Where(x => x.id_universidad == idUniversidad)
                .FirstOrDefault());
            _app_contexto.SaveChanges();
            return Ok(idUniversidad);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using proyecto_web.context;
using proyecto_web.modelos;

namespace proyecto_web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class estudiantes_controlador : ControllerBase
    {

        private readonly ILogger<estudiantes_controlador> _logger;
        private readonly app_contexto _app_contexto;
        public estudiantes_controlador(
            ILogger<estudiantes_controlador> logger,
            app_contexto app_contexto)
        {
            _logger = logger;
            _app_contexto = app_contexto;
        }
        //Create
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] estudiante estudiante)
        {
            _app_contexto.estudiantes.Add(estudiante);
            _app_contexto.SaveChanges();
            return Ok(estudiante);
        }
        //READ: 
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_app_contexto.estudiantes.ToList());

        }
        //Update:
        [Route("/id")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] estudiante estudiante)
        {
            _app_contexto.estudiantes.Update(estudiante);
            _app_contexto.SaveChanges();
            return Ok(estudiante);
        }
        //Delete: 
        [Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int idEstudiante)
        {
            _app_contexto.estudiantes.Remove(
                _app_contexto.estudiantes.ToList()
                .Where(x => x.id_estudiante == idEstudiante)
                .FirstOrDefault());
            _app_contexto.SaveChanges();
            return Ok(idEstudiante);
        }
    }
}

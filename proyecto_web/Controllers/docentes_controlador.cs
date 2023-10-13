using Microsoft.AspNetCore.Mvc;
using proyecto_web.context;
using proyecto_web.modelos;

namespace proyecto_web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class docentes_controlador : ControllerBase
    {

        private readonly ILogger<docentes_controlador> _logger;
        private readonly app_contexto _app_contexto;
        public docentes_controlador(
            ILogger<docentes_controlador> logger,
            app_contexto app_contexto)
        {
            _logger = logger;
            _app_contexto = app_contexto;
        }
        //Create
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] docente docente)
        {
            _app_contexto.docentes.Add(docente);
            _app_contexto.SaveChanges();
            return Ok(docente);
        }
        //READ: 
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_app_contexto.docentes.ToList());

        }
        //Update:
        [Route("{id}")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] docente docente)
        {
            _app_contexto.docentes.Update(docente);
            _app_contexto.SaveChanges();
            return Ok(docente);
        }
        //Delete: 
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int idDocente)
        {
            _app_contexto.docentes.Remove(
                _app_contexto.docentes.ToList()
                .Where(x => x.id_docente == idDocente)
                .FirstOrDefault());
            _app_contexto.SaveChanges();
            return Ok(idDocente);
        }
    }
}

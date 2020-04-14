using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RestauranteCodenation.Application.Interface;
using RestauranteCodenation.Application.ViewModel;

namespace RestauranteCodenation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaController : ControllerBase
    {
        private readonly IAgendaAplicacao _app;

        public AgendaController(IAgendaAplicacao app)
        {
            _app = app;
        }

        // GET: api/Agenda
        [HttpGet]
        public IEnumerable<AgendaViewModel> Get()
        {
            return _app.SelecionarTodos();
        }

        // GET: api/Agenda/5
        [HttpGet("{id}")]
        public AgendaViewModel Get(int id)
        {
            return _app.SelecionanrPorId(id);
        }

        // POST: api/Agenda
        [HttpPost]
        public AgendaViewModel Post([FromBody] AgendaViewModel agenda)
        {
            _app.Incluir(agenda);
            return agenda;
        }

        // PUT: api/Agenda/5
        [HttpPut]
        public AgendaViewModel Put([FromBody] AgendaViewModel agenda)
        {
            _app.Alterar(agenda);
            return agenda;
        }

        // DELETE: api/Agenda/5
        [HttpDelete("{id}")]
        public IEnumerable<AgendaViewModel> Delete(int id)
        {
            _app.Excluir(id);
            return _app.SelecionarTodos();
        }
    }
}

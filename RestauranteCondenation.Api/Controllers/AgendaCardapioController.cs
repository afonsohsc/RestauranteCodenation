using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RestauranteCodenation.Application.Interface;
using RestauranteCodenation.Application.ViewModel;

namespace RestauranteCodenation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaCardapioController : ControllerBase
    {
        private readonly IAgendaCardapioAplicacao _app;
        public AgendaCardapioController(IAgendaCardapioAplicacao app)
        {
            _app = app;
        }

        // GET: api/AgendaCardapio
        [HttpGet]
        public IEnumerable<AgendaCardapioViewModel> Get()
        {
            return _app.SelecionarCompleto();
        }

        // GET: api/AgendaCardapio/5
        [HttpGet("{id}")]
        public AgendaCardapioViewModel Get(int id)
        {
            return _app.SelecionanrPorId(id);
        }

        // POST: api/AgendaCardapio
        [HttpPost]
        public AgendaCardapioViewModel Post([FromBody] AgendaCardapioViewModel agendaCardapio)
        {
            _app.Incluir(agendaCardapio);
            return agendaCardapio;
        }

        // PUT: api/AgendaCardapio/5
        [HttpPut("{id}")]
        public AgendaCardapioViewModel Put([FromBody] AgendaCardapioViewModel agendaCardapio)
        {
            _app.Alterar(agendaCardapio);
            return agendaCardapio;
        }

        // DELETE: api/AgendaCardapio/5
        [HttpDelete("{id}")]
        public IEnumerable<AgendaCardapioViewModel> Delete(int id)
        {
            _app.Excluir(id);
            return _app.SelecionarTodos();
        }
    }
}

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RestauranteCodenation.Application.Interface;
using RestauranteCodenation.Application.ViewModel;

namespace RestauranteCodenation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPratoController : ControllerBase
    {
        private readonly ITipoPratoAplicacao _app;
        public TipoPratoController(ITipoPratoAplicacao app)
        {
            _app = app;
        }

        // GET: api/TipoPrato
        [HttpGet]
        public IEnumerable<TipoPratoViewModel> Get()
        {
            return _app.SelecionarTodos();
        }

        // GET: api/TipoPrato/5
        [HttpGet("{id}")]
        public TipoPratoViewModel Get(int id)
        {
            return _app.SelecionanrPorId(id);
        }

        // POST: api/TipoPrato
        [HttpPost]
        public TipoPratoViewModel Post([FromBody] TipoPratoViewModel tipoPrato)
        {
            _app.Incluir(tipoPrato);
            return tipoPrato;
        }

        // PUT: api/TipoPrato/5
        [HttpPut]
        public TipoPratoViewModel Put([FromBody] TipoPratoViewModel tipoPrato)
        {
            _app.Alterar(tipoPrato);
            return tipoPrato;
        }

        // DELETE: api/TipoPrato/5
        [HttpDelete("{id}")]
        public IEnumerable<TipoPratoViewModel> Delete(int id)
        {
            _app.Excluir(id);
            return _app.SelecionarTodos();
        }
    }
}

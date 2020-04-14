using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RestauranteCodenation.Application.Interface;
using RestauranteCodenation.Application.ViewModel;

namespace RestauranteCodenation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardapioController : ControllerBase
    {
        private readonly ICardapioAplicacao _app;
        public CardapioController(ICardapioAplicacao app)
        {
            _app = app;
        }

        // GET: api/Cardapio
        [HttpGet]
        public IEnumerable<CardapioViewModel> Get()
        {
            return _app.SelecionarTodos();
        }

        // GET: api/Cardapio/5
        [HttpGet("{id}")]
        public CardapioViewModel Get(int id)
        {
            return _app.SelecionanrPorId(id);
        }

        // POST: api/Cardapio
        [HttpPost]
        public CardapioViewModel Post([FromBody] CardapioViewModel cardapio)
        {
            _app.Incluir(cardapio);
            return cardapio;
        }

        // PUT: api/Cardapio/5
        [HttpPut]
        public CardapioViewModel Put([FromBody] CardapioViewModel cardapio)
        {
            _app.Alterar(cardapio);
            return cardapio;
        }

        // DELETE: api/Cardapio/5
        [HttpDelete("{id}")]
        public IEnumerable<CardapioViewModel> Delete(int id)
        {
            _app.Excluir(id);
            return _app.SelecionarTodos();
        }
    }
}

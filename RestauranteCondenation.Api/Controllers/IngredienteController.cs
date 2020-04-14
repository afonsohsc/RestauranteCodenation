using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RestauranteCodenation.Application.Interface;
using RestauranteCodenation.Application.ViewModel;

namespace RestauranteCodenation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredienteController : ControllerBase
    {
        private readonly IIngredienteAplicacao _app;
        public IngredienteController(IIngredienteAplicacao app)
        {
            _app = app;
        }

        // GET: api/Ingrediente
        [HttpGet]
        public IEnumerable<IngredienteViewModel> Get()
        {
            return _app.SelecionarTodos();
        }

        // GET: api/Ingrediente/5
        [HttpGet("{id}")]
        public IngredienteViewModel Get(int id)
        {
            return _app.SelecionanrPorId(id);
        }

        // POST: api/Ingrediente
        [HttpPost]
        public IngredienteViewModel Post([FromBody] IngredienteViewModel ingrediente)
        {
            _app.Incluir(ingrediente);
            return ingrediente;
        }

        // PUT: api/Ingrediente/5
        [HttpPut]
        public IngredienteViewModel Put([FromBody] IngredienteViewModel ingrediente)
        {
            _app.Alterar(ingrediente);
            return ingrediente;
        }

        // DELETE: api/Ingrediente/5
        [HttpDelete("{id}")]
        public IEnumerable<IngredienteViewModel> Delete(int id)
        {
            _app.Excluir(id);
            return _app.SelecionarTodos();
        }
    }
}

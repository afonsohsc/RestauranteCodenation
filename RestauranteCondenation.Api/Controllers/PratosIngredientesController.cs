using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RestauranteCodenation.Application.Interface;
using RestauranteCodenation.Application.ViewModel;

namespace RestauranteCodenation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PratosIngredientesController : ControllerBase
    {
        private readonly IPratosIngredientesAplicacao _app;
        public PratosIngredientesController(IPratosIngredientesAplicacao app)
        {
            _app = app;
        }

        // GET: api/PratosIngredientes
        [HttpGet]
        public IEnumerable<PratosIngredientesViewModel> Get()
        {
            return _app.SelecionarCompleto();
        }

        // GET: api/PratosIngredientes/5
        [HttpGet("{id}")]
        public PratosIngredientesViewModel Get(int id)
        {
            return _app.SelecionanrPorId(id);
        }

        // POST: api/PratosIngredientes
        [HttpPost]
        public PratosIngredientesViewModel Post([FromBody] PratosIngredientesViewModel pratosIngredientes)
        {
            _app.Incluir(pratosIngredientes);
            return pratosIngredientes;
        }

        // PUT: api/PratosIngredientes/5
        [HttpPut]
        public PratosIngredientesViewModel Put([FromBody] PratosIngredientesViewModel pratosIngredientes)
        {
            _app.Alterar(pratosIngredientes);
            return pratosIngredientes;
        }

        // DELETE: api/PratosIngredientes/5
        [HttpDelete("{id}")]
        public IEnumerable<PratosIngredientesViewModel> Delete(int id)
        {
            _app.Excluir(id);
            return _app.SelecionarTodos();
        }
    }
}

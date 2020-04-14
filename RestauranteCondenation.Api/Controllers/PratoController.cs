using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RestauranteCodenation.Application.Interface;
using RestauranteCodenation.Application.ViewModel;

namespace RestauranteCodenation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PratoController : ControllerBase
    {
        public readonly IPratoAplicacao _repo;
        public PratoController(IPratoAplicacao repo)
        {
            _repo = repo;
        }

        // GET: api/Prato
        [HttpGet]
        public IEnumerable<PratoViewModel> Get()
        {
            return _repo.SelecionarCompleto();
        }

        // GET: api/Prato/5
        [HttpGet("{id}")]
        public PratoViewModel Get(int id)
        {
            return _repo.SelecionanrPorId(id);
        }

        // POST: api/Prato
        [HttpPost]
        public PratoViewModel Post([FromBody] PratoViewModel prato)
        {
            _repo.Incluir(prato);
            return prato;
        }

        // PUT: api/Prato/5
        [HttpPut]
        public PratoViewModel Put([FromBody] PratoViewModel prato)
        {
            _repo.Alterar(prato);
            return prato;
        }

        // DELETE: api/Prato/5
        [HttpDelete("{id}")]
        public IEnumerable<PratoViewModel> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}

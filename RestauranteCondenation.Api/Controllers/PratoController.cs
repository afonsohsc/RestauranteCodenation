using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestauranteCodenation.Data.Repositorio;
using RestauranteCodenation.Domain.Modelo;
using RestauranteCodenation.Domain.Repositorio;

namespace RestauranteCodenation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PratoController : ControllerBase
    {
        public readonly IPratoRepositorio _repo;
        public PratoController(IPratoRepositorio repo)
        {
            _repo = repo;
        }

        // GET: api/Prato
        [HttpGet]
        public IEnumerable<Prato> Get()
        {
            return _repo.SelecionarCompleto();
        }

        // GET: api/Prato/5
        [HttpGet("{id}")]
        public Prato Get(int id)
        {
            return _repo.SelecionanrPorId(id);
        }

        // POST: api/Prato
        [HttpPost]
        public Prato Post([FromBody] Prato prato)
        {
            _repo.Incluir(prato);
            return prato;
        }

        // PUT: api/Prato/5
        [HttpPut]
        public Prato Put([FromBody] Prato prato)
        {
            _repo.Alterar(prato);
            return prato;
        }

        // DELETE: api/Prato/5
        [HttpDelete("{id}")]
        public IEnumerable<Prato> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}

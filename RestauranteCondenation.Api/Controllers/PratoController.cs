using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestauranteCodenation.Data.Repositorio;
using RestauranteCodenation.Domain.Modelo;

namespace RestauranteCodenation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PratoController : ControllerBase
    {
        public readonly PratoRepositorio _repo;
        public PratoController()
        {
            _repo = new PratoRepositorio();
        }

        // GET: api/Prato
        [HttpGet]
        public IEnumerable<Prato> Get()
        {
            return _repo.SelecionarTodos();
        }

        // GET: api/Prato/5
        [HttpGet("{id}", Name = "Get")]
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

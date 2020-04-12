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
    public class AgendaCardapioController : ControllerBase
    {
        private readonly IAgendaCardapioRepositorio _repo;
        public AgendaCardapioController(IAgendaCardapioRepositorio repo)
        {
            _repo = repo;
        }

        // GET: api/AgendaCardapio
        [HttpGet]
        public IEnumerable<AgendaCardapio> Get()
        {
            return _repo.SelecionarCompleto();
        }

        // GET: api/AgendaCardapio/5
        [HttpGet("{id}")]
        public AgendaCardapio Get(int id)
        {
            return _repo.SelecionanrPorId(id);
        }

        // POST: api/AgendaCardapio
        [HttpPost]
        public AgendaCardapio Post([FromBody] AgendaCardapio agendaCardapio)
        {
            _repo.Incluir(agendaCardapio);
            return agendaCardapio;
        }

        // PUT: api/AgendaCardapio/5
        [HttpPut("{id}")]
        public AgendaCardapio Put([FromBody] AgendaCardapio agendaCardapio)
        {
            _repo.Alterar(agendaCardapio);
            return agendaCardapio;
        }

        // DELETE: api/AgendaCardapio/5
        [HttpDelete("{id}")]
        public IEnumerable<AgendaCardapio> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}

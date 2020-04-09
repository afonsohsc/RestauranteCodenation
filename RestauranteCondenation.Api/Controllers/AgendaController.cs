﻿using System;
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
    public class AgendaController : ControllerBase
    {
        private readonly AgendaRepositorio _repo;

        public AgendaController()
        {
            _repo = new AgendaRepositorio();
        }

        // GET: api/Agenda
        [HttpGet]
        public IEnumerable<Agenda> Get()
        {
            return _repo.SelecionarTodos();
        }

        // GET: api/Agenda/5
        [HttpGet("{id}", Name = "Get")]
        public Agenda Get(int id)
        {
            return _repo.SelecionanrPorId(id);
        }

        // POST: api/Agenda
        [HttpPost]
        public Agenda Post([FromBody] Agenda agenda)
        {
            _repo.Incluir(agenda);
            return agenda;
        }

        // PUT: api/Agenda/5
        [HttpPut]
        public Agenda Put([FromBody] Agenda agenda)
        {
            _repo.Alterar(agenda);
            return agenda;
        }

        // DELETE: api/Agenda/5
        [HttpDelete("{id}")]
        public IEnumerable<Agenda> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}

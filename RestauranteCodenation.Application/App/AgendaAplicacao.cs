using AutoMapper;
using RestauranteCodenation.Application.Interface;
using RestauranteCodenation.Application.ViewModel;
using RestauranteCodenation.Domain.Modelo;
using RestauranteCodenation.Domain.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Application.App
{
    public class AgendaAplicacao : IAgendaAplicacao
    {
        private readonly IAgendaRepositorio _repo;
        private readonly IMapper _mapper;

        public AgendaAplicacao(IAgendaRepositorio repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Alterar(AgendaViewModel entity)
        {
            _repo.Alterar(_mapper.Map<Agenda>(entity));
        }

        public void Excluir(int id)
        {
            _repo.Excluir(id);
        }

        public void Incluir(AgendaViewModel entity)
        {
            _repo.Incluir(_mapper.Map<Agenda>(entity));
        }

        public AgendaViewModel SelecionanrPorId(int id)
        {
            return _mapper.Map<AgendaViewModel>(_repo.SelecionanrPorId(id));
        }

        public IEnumerable<AgendaViewModel> SelecionarTodos()
        {
            return _mapper.Map<IEnumerable<AgendaViewModel>>(_repo.SelecionarTodos());
        }
    }
}

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
    public class AgendaCardapioAplicacao : IAgendaCardapioAplicacao
    {
        private readonly IAgendaCardapioRepositorio _repo;
        private readonly IMapper _mapper;

        public AgendaCardapioAplicacao(IAgendaCardapioRepositorio repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Alterar(AgendaCardapioViewModel entity)
        {
            _repo.Alterar(_mapper.Map<AgendaCardapio>(entity));
        }

        public void Excluir(int id)
        {
            _repo.Excluir(id);
        }

        public void Incluir(AgendaCardapioViewModel entity)
        {
            _repo.Incluir(_mapper.Map<AgendaCardapio>(entity));
        }

        public AgendaCardapioViewModel SelecionanrPorId(int id)
        {
            return _mapper.Map<AgendaCardapioViewModel>(_repo.SelecionanrPorId(id));
        }

        public IEnumerable<AgendaCardapioViewModel> SelecionarCompleto()
        {
            return _mapper.Map<IEnumerable<AgendaCardapioViewModel>>(_repo.SelecionarCompleto());
        }

        public IEnumerable<AgendaCardapioViewModel> SelecionarTodos()
        {
            return _mapper.Map<IEnumerable<AgendaCardapioViewModel>>(_repo.SelecionarTodos());
        }
    }
}

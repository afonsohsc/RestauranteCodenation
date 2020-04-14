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
    public class TipoPratoAplicacao : ITipoPratoAplicacao
    {
        private readonly ITipoPratoRepositorio _repo;
        private readonly IMapper _mapper;

        public TipoPratoAplicacao(ITipoPratoRepositorio repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Alterar(TipoPratoViewModel entity)
        {
            _repo.Alterar(_mapper.Map<TipoPrato>(entity));
        }

        public void Excluir(int id)
        {
            _repo.Excluir(id);
        }

        public void Incluir(TipoPratoViewModel entity)
        {
            _repo.Incluir(_mapper.Map<TipoPrato>(entity));
        }

        public TipoPratoViewModel SelecionanrPorId(int id)
        {
            return _mapper.Map<TipoPratoViewModel>(_repo.SelecionanrPorId(id));
        }

        public IEnumerable<TipoPratoViewModel> SelecionarTodos()
        {
            return _mapper.Map<IEnumerable<TipoPratoViewModel>>(_repo.SelecionarTodos());
        }
    }
}

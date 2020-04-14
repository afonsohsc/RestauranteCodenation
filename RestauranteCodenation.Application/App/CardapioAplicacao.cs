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
    public class CardapioAplicacao : ICardapioAplicacao
    {
        private readonly ICardapioRepositorio _repo;
        private readonly IMapper _mapper;

        public CardapioAplicacao(ICardapioRepositorio repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Alterar(CardapioViewModel entity)
        {
            _repo.Alterar(_mapper.Map<Cardapio>(entity));
        }

        public void Excluir(int id)
        {
            _repo.Excluir(id);
        }

        public void Incluir(CardapioViewModel entity)
        {
            _repo.Incluir(_mapper.Map<Cardapio>(entity));
        }

        public CardapioViewModel SelecionanrPorId(int id)
        {
            return _mapper.Map<CardapioViewModel>(_repo.SelecionanrPorId(id));
        }

        public IEnumerable<CardapioViewModel> SelecionarTodos()
        {
            return _mapper.Map<IEnumerable<CardapioViewModel>>(_repo.SelecionarTodos());
        }
    }
}

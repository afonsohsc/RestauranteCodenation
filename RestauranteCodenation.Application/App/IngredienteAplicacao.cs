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
    public class IngredienteAplicacao : IIngredienteAplicacao
    {
        private readonly IIngredienteRepositorio _repo;
        private readonly IMapper _mapper;

        public IngredienteAplicacao(IIngredienteRepositorio repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Alterar(IngredienteViewModel entity)
        {
            _repo.Alterar(_mapper.Map<Ingrediente>(entity));
        }

        public void Excluir(int id)
        {
            _repo.Excluir(id);
        }

        public void Incluir(IngredienteViewModel entity)
        {
            _repo.Incluir(_mapper.Map<Ingrediente>(entity));
        }

        public IngredienteViewModel SelecionanrPorId(int id)
        {
            return _mapper.Map<IngredienteViewModel>(_repo.SelecionanrPorId(id));
        }

        public IEnumerable<IngredienteViewModel> SelecionarTodos()
        {
            return _mapper.Map<IEnumerable<IngredienteViewModel>>(_repo.SelecionarTodos());
        }
    }
}

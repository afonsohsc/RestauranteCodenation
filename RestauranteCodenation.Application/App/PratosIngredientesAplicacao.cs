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
    public class PratosIngredientesAplicacao : IPratosIngredientesAplicacao
    {
        private readonly IPratosIngredientesRepositorio _repo;
        private readonly IMapper _mapper;

        public PratosIngredientesAplicacao(IPratosIngredientesRepositorio repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Alterar(PratosIngredientesViewModel entity)
        {
            _repo.Alterar(_mapper.Map<PratosIngredientes>(entity));
        }

        public void Excluir(int id)
        {
            _repo.Excluir(id);
        }

        public void Incluir(PratosIngredientesViewModel entity)
        {
            _repo.Incluir(_mapper.Map<PratosIngredientes>(entity));
        }

        public PratosIngredientesViewModel SelecionanrPorId(int id)
        {
            return _mapper.Map<PratosIngredientesViewModel>(_repo.SelecionanrPorId(id));
        }

        public IEnumerable<PratosIngredientesViewModel> SelecionarCompleto()
        {
            return _mapper.Map<IEnumerable<PratosIngredientesViewModel>>(_repo.SelecionarCompleto());
        }

        public IEnumerable<PratosIngredientesViewModel> SelecionarTodos()
        {
            return _mapper.Map<IEnumerable<PratosIngredientesViewModel>>(_repo.SelecionarTodos());
        }
    }
}

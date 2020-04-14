using RestauranteCodenation.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Application.Interface
{
    public interface IIngredienteAplicacao
    {
        void Incluir(IngredienteViewModel entity);
        void Alterar(IngredienteViewModel entity);
        void Excluir(int id);
        IngredienteViewModel SelecionanrPorId(int id);
        IEnumerable<IngredienteViewModel> SelecionarTodos();
    }
}

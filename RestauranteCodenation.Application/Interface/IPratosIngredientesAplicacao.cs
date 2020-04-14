using RestauranteCodenation.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Application.Interface
{
    public interface IPratosIngredientesAplicacao
    {
        void Incluir(PratosIngredientesViewModel entity);
        void Alterar(PratosIngredientesViewModel entity);
        void Excluir(int id);
        PratosIngredientesViewModel SelecionanrPorId(int id);
        IEnumerable<PratosIngredientesViewModel> SelecionarTodos();
        IEnumerable<PratosIngredientesViewModel> SelecionarCompleto();
    }
}

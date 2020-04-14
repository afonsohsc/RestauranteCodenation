using RestauranteCodenation.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Application.Interface
{
    public interface IAgendaCardapioAplicacao
    {
        void Incluir(AgendaCardapioViewModel entity);
        void Alterar(AgendaCardapioViewModel entity);
        void Excluir(int id);
        AgendaCardapioViewModel SelecionanrPorId(int id);
        IEnumerable<AgendaCardapioViewModel> SelecionarTodos();
        IEnumerable<AgendaCardapioViewModel> SelecionarCompleto();
    }
}

using RestauranteCodenation.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Application.Interface
{
    public interface IAgendaAplicacao
    {
        void Incluir(AgendaViewModel entity);
        void Alterar(AgendaViewModel entity);
        void Excluir(int id);
        AgendaViewModel SelecionanrPorId(int id);
        IEnumerable<AgendaViewModel> SelecionarTodos();
    }
}

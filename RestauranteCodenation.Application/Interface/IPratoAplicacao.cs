using RestauranteCodenation.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Application.Interface
{
    public interface IPratoAplicacao
    {
        void Incluir(PratoViewModel entity);
        void Alterar(PratoViewModel entity);
        void Excluir(int id);
        PratoViewModel SelecionanrPorId(int id);
        IEnumerable<PratoViewModel> SelecionarTodos();
        IEnumerable<PratoViewModel> SelecionarCompleto();
    }
}

using RestauranteCodenation.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Application.Interface
{
    public interface ITipoPratoAplicacao
    {
        void Incluir(TipoPratoViewModel entity);
        void Alterar(TipoPratoViewModel entity);
        void Excluir(int id);
        TipoPratoViewModel SelecionanrPorId(int id);
        IEnumerable<TipoPratoViewModel> SelecionarTodos();
    }
}

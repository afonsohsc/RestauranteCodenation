using RestauranteCodenation.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Application.Interface
{
    public interface ICardapioAplicacao
    {
        void Incluir(CardapioViewModel entity);
        void Alterar(CardapioViewModel entity);
        void Excluir(int id);
        CardapioViewModel SelecionanrPorId(int id);
        IEnumerable<CardapioViewModel> SelecionarTodos();
    }
}

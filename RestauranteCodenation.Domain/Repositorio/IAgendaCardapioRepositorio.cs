using RestauranteCodenation.Domain.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Domain.Repositorio
{
    public interface IAgendaCardapioRepositorio : IRepositorioBase<AgendaCardapio>
    {
        IEnumerable<AgendaCardapio> SelecionarCompleto();
    }
}

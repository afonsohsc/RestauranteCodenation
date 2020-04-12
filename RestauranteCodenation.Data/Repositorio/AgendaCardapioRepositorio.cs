using Microsoft.EntityFrameworkCore;
using RestauranteCodenation.Domain.Modelo;
using RestauranteCodenation.Domain.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestauranteCodenation.Data.Repositorio
{
    public class AgendaCardapioRepositorio : RepositorioBase<AgendaCardapio>, IAgendaCardapioRepositorio
    {
        public IEnumerable<AgendaCardapio> SelecionarCompleto()
        {
            return _contexto.AgendaCardapio
                            .Include(x => x.Agenda)
                            .Include(x => x.Cardapio)
                            .ToList();
        }
    }
}

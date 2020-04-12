using Microsoft.EntityFrameworkCore;
using RestauranteCodenation.Domain.Modelo;
using RestauranteCodenation.Domain.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestauranteCodenation.Data.Repositorio
{
    public class PratoRepositorio : RepositorioBase<Prato>, IPratoRepositorio
    {
        public IEnumerable<Prato> SelecionarCompleto()
        {
            return _contexto.Prato
                            .Include(x => x.TipoPrato)
                            .ToList();
        }
    }
}

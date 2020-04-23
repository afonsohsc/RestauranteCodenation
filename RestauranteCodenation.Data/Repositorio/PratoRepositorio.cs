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
        public PratoRepositorio(Contexto contexto) : base(contexto)
        {

        }

        public IEnumerable<Prato> SelecionarCompleto()
        {
            return _contexto.Prato
                            .Include(x => x.TipoPrato)
                            .ToList();
        }
    }
}

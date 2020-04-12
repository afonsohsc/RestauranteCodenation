using Microsoft.EntityFrameworkCore;
using RestauranteCodenation.Domain.Modelo;
using RestauranteCodenation.Domain.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestauranteCodenation.Data.Repositorio
{
    public class PratosIngredientesRepositorio : RepositorioBase<PratosIngredientes>, IPratosIngredientesRepositorio
    {
        public IEnumerable<PratosIngredientes> SelecionarCompleto()
        {
            return _contexto.PratosIngredientes
                            .Include(x => x.Ingrediente)
                            .ThenInclude(x=>x.PratosIngredientes)
                            .Include(x => x.Prato)
                            .ThenInclude(x=>x.TipoPrato)
                            .ToList();
        }
    }
}

using RestauranteCodenation.Domain.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Domain.Repositorio
{
    public interface IPratoRepositorio : IRepositorioBase<Prato>
    {
        IEnumerable<Prato> SelecionarCompleto();
    }
}

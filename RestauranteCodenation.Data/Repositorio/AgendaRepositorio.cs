using RestauranteCodenation.Domain.Modelo;
using RestauranteCodenation.Domain.Repositorio;

namespace RestauranteCodenation.Data.Repositorio
{
    public class AgendaRepositorio : RepositorioBase<Agenda>, IAgendaRepositorio
    {
        public AgendaRepositorio(Contexto contexto) : base(contexto)
        {

        }
    }
}

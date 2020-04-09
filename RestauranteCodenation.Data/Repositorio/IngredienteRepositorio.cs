using RestauranteCodenation.Domain.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestauranteCodenation.Data.Repositorio
{
    public class IngredienteRepositorio : RepositorioBase<Ingrediente>
    {
        public void Alterar(int id, Ingrediente ingrediente)
        {
            var find = SelecionanrPorId(id);
            find.Descricao = ingrediente.Descricao;
            find.Nome = ingrediente.Nome;
            find.Validade = ingrediente.Validade;
            _contexto.SaveChanges();
        }
    }
}

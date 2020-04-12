using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Domain.Repositorio
{
    public interface IRepositorioBase<T> : IDisposable  where T : class, IEntity
    {
        void Incluir(T entity);
        void Alterar(T entity);
        void Excluir(int id);
        T SelecionanrPorId(int id);
        IEnumerable<T> SelecionarTodos();
    }
}

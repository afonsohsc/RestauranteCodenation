using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteCodenation.Domain.Repositorio
{
    public interface IUsuarioRepositorio
    {
        Task<bool> Incluir(string login, string email, string senha, string perfil = null);

        Task<IdentityUser> Login(string email, string senha);
    }
}

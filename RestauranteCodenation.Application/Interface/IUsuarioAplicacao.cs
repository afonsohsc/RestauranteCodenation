using Microsoft.AspNetCore.Identity;
using RestauranteCodenation.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteCodenation.Application.Interface
{
    public interface IUsuarioAplicacao
    {
        Task<bool> Incluir(UsuarioViewModel usuario);

        Task<string> Login(LoginViewModel login);
    }
}

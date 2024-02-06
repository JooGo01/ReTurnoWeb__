using Microsoft.EntityFrameworkCore;
using ReTurnoWeb_.Models;


namespace ReTurnoWeb_.Servicios.Contrato
{
    public interface IUsuario
    {
        Task<Usuario> GetUsuario(String mail, String pwd);
        Task<Usuario> GuardarUsuario(Usuario usr);
    }
}

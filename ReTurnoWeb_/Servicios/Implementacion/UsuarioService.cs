using Microsoft.EntityFrameworkCore;
using ReTurnoWeb_.Models;
using ReTurnoWeb_.Servicios.Contrato;

namespace ReTurnoWeb_.Servicios.Implementacion
{
    public class UsuarioService : IUsuario
    {
        private readonly ReTurnoContext dbContext;

        public UsuarioService(ReTurnoContext p_dbContext)
        {
            this.dbContext = p_dbContext;
        }
        public async Task<Usuario> GetUsuario(string mail, string pwd)
        {
            Usuario usr = await dbContext.Usuarios.Where(u=> u.Email == mail && u.Contrasenia==pwd).FirstOrDefaultAsync();
            return usr;
        }

        public async Task<Usuario> GuardarUsuario(Usuario usr)
        {
            dbContext.Usuarios.Add(usr);
            await dbContext.SaveChangesAsync();
            return usr;
        }
    }
}

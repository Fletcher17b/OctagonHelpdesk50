using System.Linq;
using OctagonHelpdesk.Models;
using OctagonHelpdesk.Services;

namespace OctagonHelpdesk.Helpers
{
    public static class AuthenticationService
    {
        private static UsuarioDao usuarioDao = new UsuarioDao();

        public static bool ValidateCredentials(string username, string password)
        {
            UserModel user = usuarioDao.GetUsuario(username);
            if (user != null)
            {
                return HelperPassword.VerifyPassword(password, user.EncryptedPassword);
            }
            return false;
        }

        public static UserModel GetCurrentUser(string username)
        {
            return usuarioDao.GetUsuario(username);
        }
    }
}

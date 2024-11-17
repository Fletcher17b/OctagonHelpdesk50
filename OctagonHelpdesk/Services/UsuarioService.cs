using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OctagonHelpdesk.Models;


namespace OctagonHelpdesk.Services
{
    public class UsuarioService
    {
        private List<UserModel> usuarios = new List<UserModel>();
        
        public UsuarioService() 
        {
            MassFillLocal();
        }

        private void MassFillLocal()
        {
            UserModel TestingUser = new UserModel();
            TestingUser.MassFill(1, true, "123");
            AddUsuario(TestingUser);
        }



        public void AddUsuario(UserModel usuario)
        {
            usuario.CreationDate = DateTime.Now;
            usuarios.Add(usuario);

        }
        //public void RemoveUsuario(UserModel LoggedUser,UserModel usuario)
        public void RemoveUsuario(UserModel usuario)
        {
            int position = FindPosition(usuario.IDUser);
            usuarios[position].ActiveStateU = false;
            usuarios[position].DeactivationDate = DateTime.Now;

        }
        public void UpdateUsuario(UserModel usuario)
        {
            int position = FindPosition(usuario.IDUser);
            usuarios[position] = usuario;
            usuarios[position].LastUpdatedDate = DateTime.Now;
        }

        public List<UserModel> GetUsuarios()
        {
            return usuarios;
        }

        public UserModel GetUsuario(int id)
        {
            return usuarios.Find(usuario => usuario.IDUser == id);
        }

        public int AutogeneradorID()
        {
            if (usuarios.Count == 0)
            {
                return 1;
            }
            return usuarios.Last().IDUser + 1;
        }
        public int FindPosition(int id)
        {
            return usuarios.FindIndex(usuario => usuario.IDUser == id);

        }


        public bool CheckUser(string UserID, string password)
        {
            int ID = 0;
            try
            {
                ID = int.Parse(UserID);
            }
            catch { }
            
            for (int i = 0; i < usuarios.Count; i++)
            {
                if ((ID == usuarios[i].IDUser)&&ID != 0) 
                { 
                    if (usuarios[i].ChecKPassword(password))
                    {
                        return true;
                    }

                }
            }

            return false;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using OctagonHelpdesk.Services;
using OctagonHelpdesk.Models.Enum;
using System.Windows.Forms;


namespace OctagonHelpdesk.Models
{
    public class UserModel
    {
        // Alicia: Nota: Cambie el orden de los atributos


        // Nota: si esta en ingles ignoralo
        // SI ESTA EN ESPAÑOL LEELO
        public int IDUser { get; set; }

        //En vez de eliminar al empleado, solo se desactiva su Estado
        public bool ActiveStateU { get; set; }

        public Role Roles;
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public Departament Departamento { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public DateTime? ReactivationDate { get; set; }


        private string EncryptedPassword;

        // Implementar UserRoles -M

        public UserModel()
        {
            Roles = new Role();

            //Mario: Logica basica es asi: en cuanto se crea el objeto y se le asignan las propiedades de un usuario existente
            // se busca entre donde esten almacenados los roles y se le asigna
            // la creacion de usuario va en otro lugar, en esta clase se trabaja con la asumcion de que el usuario ya existe
            UserRolesService userRolesService = new UserRolesService();
            userRolesService.RetrieveRoles(this);
            // Mario: To do, Find a way to dispose of the UserRolesServices after it's used so it doesn't hog memory

        }

        public void SetPassword(string password, bool loggedin)
        {
            if (loggedin && !HelperPassword.Checkifhashed(password))
            {
                EncryptedPassword = HelperPassword.HashPassword(password);
            }

            if (HelperPassword.Checkifhashed(password))
            {
                EncryptedPassword = password;
            }
        }

        public string GetPassword(bool loggedin)
        {
            return EncryptedPassword;
        }



        public bool ChecKPassword(string password)
        {
            FileHelper fileHelper = new FileHelper();
            UserModel temp;
            temp = fileHelper.GetUser(this.IDUser);
            Console.WriteLine("Stored:" + temp.GetPassword(true));
            Console.WriteLine("Input:" + HelperPassword.HashPassword(password));
            return HelperPassword.VerifyPassword(password, temp.GetPassword(true));
        }


        public void MassFill(int IDuser,bool state, string password, string name)
        {
            Random random = new Random();
            
            this.Roles.AdminPerms = false;
            this.Roles.ITPerms = false;
            this.Roles.BasicPerms = true;
            this.Name = GetRandomString(8);
            this.Lastname = GetRandomString(10);
            this.Email = $"{this.Name}{this.Lastname}@example.com";
            this.Departamento = new Departament {};
            this.CreationDate = GetRandomDate();
            this.LastUpdatedDate = GetRandomDate();
            this.DeactivationDate = GetRandomDate();
            this.ReactivationDate = GetRandomDate();
            

            this.IDUser = IDuser;
            this.ActiveStateU = state;
            this.SetPassword(password,true);
            this.Name = name;  
        }


        // Helper methods, gonna delete later
        private string GetRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                stringBuilder.Append(chars[random.Next(chars.Length)]);
            }
            return stringBuilder.ToString();
        }

        private DateTime GetRandomDate()
        {
            Random random = new Random();
            int range = (DateTime.Today - new DateTime(2000, 1, 1)).Days;
            return new DateTime(2000, 1, 1).AddDays(random.Next(range));
        }
    }
}

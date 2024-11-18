using OctagonHelpdesk.Models;
using OctagonHelpdesk.Models.Enum;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OctagonHelpdesk.Services
{
    internal class FileHelper
    {
        private string rutaArchivo = @"data\data.dat";


        private DateTime dateformater(string date)
        {
            return DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }
        public void SaveUser(List<UserModel> userLists, bool perms)
        {
            using (FileStream archivo = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter escritor = new BinaryWriter(archivo))
                {
                    foreach (UserModel user in userLists)
                    {
                        escritor.Write(user.IDUser);
                        escritor.Write(user.ActiveStateU);
                        escritor.Write(user.Roles.AdminPerms);
                        escritor.Write(user.Roles.ITPerms);
                        escritor.Write(user.Roles.BasicPerms);
                        escritor.Write(user.Name);
                        escritor.Write(user.Lastname);
                        escritor.Write(user.Email);
                        escritor.Write((int)user.Departamento);
                        string fechaComoCadena = user.CreationDate.ToString("dd/MM/yyyy");
                        escritor.Write(fechaComoCadena);
                        escritor.Write(user.GetPassword(perms));
                        escritor.Write(user.CreationDate.ToString("dd/MM/yyyy"));
                        escritor.Write(user.LastUpdatedDate.ToString("dd/MM/yyyy"));
                        escritor.Write(user.DeactivationDate.ToString("dd/MM/yyyy"));
                        escritor.Write(user.ReactivationDate.ToString("dd/MM/yyyy"));
                    }
                }
            }
        }

        public List<UserModel> GetUsers()
        {
            List<UserModel> userModels = new List<UserModel>();
            if (!File.Exists(rutaArchivo)) return null;

            using (FileStream archivo = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader lector = new BinaryReader(archivo))
                {
                    while (archivo.Position < archivo.Length)
                    {
                        try
                        {
                            UserModel userModel = new UserModel
                            {
                                IDUser = lector.ReadInt32(),
                                ActiveStateU = lector.ReadBoolean(),
                                Roles = new Role
                                {
                                    AdminPerms = lector.ReadBoolean(),
                                    ITPerms = lector.ReadBoolean(),
                                    BasicPerms = lector.ReadBoolean()
                                },
                                Name = lector.ReadString(),
                                Lastname = lector.ReadString(),
                                Email = lector.ReadString(),
                                Departamento = (Departament)lector.ReadInt32()
                            };

                            string fechaComoCadena = lector.ReadString();
                            userModel.CreationDate = DateTime.ParseExact(fechaComoCadena, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                            userModel.SetPassword(lector.ReadString(), false);
                            userModel.CreationDate = DateTime.ParseExact(lector.ReadString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            userModel.LastUpdatedDate = DateTime.ParseExact(lector.ReadString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            userModel.DeactivationDate = DateTime.ParseExact(lector.ReadString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            userModel.ReactivationDate = DateTime.ParseExact(lector.ReadString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                            userModels.Add(userModel);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
                        }
                    }
                }
            }
            return userModels;
        }



        public UserModel GetUser(int TargetID)
        {
            UserModel userModels = new UserModel();
            if (!File.Exists(rutaArchivo)) return null;

            using (FileStream archivo = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader lector = new BinaryReader(archivo))
                {
                    while (archivo.Position != archivo.Length)
                    {
                        UserModel userModel = new UserModel
                            {
                                IDUser = lector.ReadInt32(),
                                ActiveStateU = lector.ReadBoolean(),
                                Roles = new Role
                                {
                                    AdminPerms = lector.ReadBoolean(),
                                    ITPerms = lector.ReadBoolean(),
                                    BasicPerms = lector.ReadBoolean()
                                },
                                Name = lector.ReadString(),
                                Lastname = lector.ReadString(),
                                Email = lector.ReadString(),
                                Departamento = (Departament)lector.ReadInt32()
                            };

                            string fechaComoCadena = lector.ReadString();
                            userModel.CreationDate = DateTime.ParseExact(fechaComoCadena, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                            userModel.SetPassword(lector.ReadString(), false);
                            userModel.CreationDate = DateTime.ParseExact(lector.ReadString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            userModel.LastUpdatedDate = DateTime.ParseExact(lector.ReadString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            userModel.DeactivationDate = DateTime.ParseExact(lector.ReadString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            userModel.ReactivationDate = DateTime.ParseExact(lector.ReadString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                        if (userModel.IDUser == TargetID)
                        {
                            return userModel;
                        }

                    }
                }
            }
            return null;
        }
    }
}

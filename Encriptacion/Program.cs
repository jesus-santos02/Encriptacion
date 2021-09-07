using System;

namespace Encriptacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //string pass = "jesusito02";
            //string encryptPass = Encrypt.GetSHA256(pass);

            using (Models.Db.EncriptacionContext db = new Models.Db.EncriptacionContext())
            {
                Models.Db.Usuario user = new Models.Db.Usuario();
                user.Nombre = "Jesus Maria Santos";
                user.Contraseña = Encrypt.GetSHA256("jesusito02");

                db.Usuarios.Add(user);
                db.SaveChanges();
            }


            //Console.WriteLine(encryptPass);
        }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Encriptacion.Models.Db
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
    }
}

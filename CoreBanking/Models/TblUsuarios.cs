using System;
using System.Collections.Generic;

namespace CoreBanking.Models
{
    public partial class TblUsuarios
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string TipoUsuario { get; set; }
    }
}

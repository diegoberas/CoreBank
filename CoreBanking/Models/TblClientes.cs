using System;
using System.Collections.Generic;

namespace CoreBanking.Models
{
    public partial class TblClientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Usuario { get; set; }
    }
}

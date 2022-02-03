using System;
using System.Collections.Generic;

namespace CoreBanking.Models
{
    public partial class TblTransaccion
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string TipoTransaccion { get; set; }
        public string NombreProducto { get; set; }
        public decimal PrecioProducto { get; set; }
        public int IdCuentaEmisora { get; set; }
        public int IdCuentaReceptora { get; set; }
        public DateTime FechaTransaccion { get; set; }
    }
}

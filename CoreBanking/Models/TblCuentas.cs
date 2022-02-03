using System;
using System.Collections.Generic;

namespace CoreBanking.Models
{
    public partial class TblCuentas
    {
        public int Id { get; set; }
        public string Propietario { get; set; }
        public string Cedula { get; set; }
        public string Tipo { get; set; }
        public string Moneda { get; set; }
        public decimal Balance { get; set; }
        public string Estado { get; set; }
        public DateTime UltimaVisita { get; set; }
    }
}

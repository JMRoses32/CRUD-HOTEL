using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementWinForms.Models
{
    internal class Pagos
    {
        [Key]
        public int Id_Pago { get; set; }
        public string Tipo { get; set; }
        public string No_Tarjeta { get; set; }
        public DateTime Fecha_Exp { get; set; }
    }
}

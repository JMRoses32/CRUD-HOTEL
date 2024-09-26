using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementWinForms.Models
{
    internal class Reserva
    {
        [Key]
        public int Id_Reserva { get; set; }
        public int Id_Huésped { get; set; }
        public int Id_Habitación { get; set; }
        public DateTime Fecha_Entrada { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public int Días { get; set; }
        public decimal Costo { get; set; }
        public int Id_Pago { get; set; }
        public string Estado_Pago { get; set; }

        // Relaciones con otras entidades
        public virtual Huésped Huésped { get; set; }
        public virtual Habitación Habitación { get; set; }
        public virtual Pagos Pagos { get; set; }
    }
}

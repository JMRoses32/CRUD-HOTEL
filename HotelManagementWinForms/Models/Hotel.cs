using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementWinForms.Models
{
    internal class Hotel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Hotel { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public int Número { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public int CP { get; set; }
        public string WWW { get; set; }
        public long Teléfono_Recepción { get; set; }
        public long Teléfono_Reserva { get; set; }
        public string Categoría { get; set; }


        // Relación con el modelo Habitación
        public virtual ICollection<Habitación> Habitaciones { get; set; }
    }
}

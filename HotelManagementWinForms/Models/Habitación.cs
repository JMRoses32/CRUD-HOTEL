using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelManagementWinForms.Models
{
    internal class Habitación
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Habitación { get; set; }
        public string Tipo_Habitación { get; set; }
        public string Descripción { get; set; }
        public int No_Personas { get; set; }
        public int Id_Hotel { get; set; }
        public int Precio { get; set; }

        // Relación con el modelo Hotel
        public virtual Hotel Hotel { get; set; }
    }
}

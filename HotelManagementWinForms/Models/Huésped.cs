using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementWinForms.Models
{
    internal class Huésped
    {
        [Key]
        public int Id_Huésped { get; set; }
        public string Nombre { get; set; }
        public string Apellido_P { get; set; }
        public string Apellido_M { get; set; }
        public long Tel_Cel { get; set; }
        public long Tel_Fijo { get; set; }
        public string Calle { get; set; }
        public string Número { get; set; }
        public string Colonia { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public int CP { get; set; }

    }
}

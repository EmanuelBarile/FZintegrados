using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
    public class RegistroDeRecorredorDTO
    {
        [Key]
        public int Id_Registro { get; set; }

        //[DataType(DataType.Date)]
        //[DefaultValue(typeof(DateTime), "DateTime.Now")]
        public DateTime Fecha { get; set; } 

        public string Hora { get; set; } 

        public int Id_Recorredor { get; set; }

        public string Cod_Integrado { get; set; }

        public string Galpon { get; set; }  

        public int Id_Diagnostico { get; set; }

        public int Id_Medicamento { get; set; }

        public int Cantidad_Aves { get; set; }

        public string Cantidad_Medicamento { get; set; }

        public int Cantidad_Dias_Tratamiento { get; set; }

        public string Comentario { get; set; }

        public DateTime Fecha_Real { get; set; } = DateTime.Now;
    }
}

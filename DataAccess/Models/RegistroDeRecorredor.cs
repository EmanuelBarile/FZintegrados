using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DataAccess.Models
{
    public class RegistroDeRecorredor
    {        
        public int Id_Registro { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime Hora { get; set; }

        public int Id_Recorredor { get; set; }

        public int Id_Integrado { get; set; }

        public string Galpon { get; set; }

        public int Id_Diagnostico { get; set; }

        public int Id_Medicamento { get; set; }

        public int Cantidad_Medicamento { get; set; }

        public int Cantidad_Dias_Tratamiento { get; set; }

        public string Comentario { get; set; }

        public DateTime Fecha_Real { get; set; }

        
        public virtual Recorredor Recorredor { get; set; }

        public virtual Integrado Integrado { get; set; }
        public virtual Diagnostico Diagnostico { get; set; }
        public virtual Medicamento Medicamento { get; set; }
        
    }
}

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
        [Key]
        [Column(TypeName = "INT")]
        public int Id_Registro { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime Fecha { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime Hora { get; set; }


        [ForeignKey("Recorredor")]
        [Column(TypeName = "INT")]
        public int Id_Recorredor { get; set; }


        [Required]
        [ForeignKey("Integrado")]
        [Column(TypeName = "INT")]
        public int Id_Integrado { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        public string Galpon { get; set; }


        [Required]
        [ForeignKey("Diagnostico")]
        [Column(TypeName = "INT")]
        public int Id_Diagnostico { get; set; }


        [Required]
        [ForeignKey("Medicamento")]
        [Column(TypeName = "INT")]
        public int Id_Medicamento { get; set; }


        [Required]
        [Column(TypeName = "INT")]
        public int Cantidad_Medicamento { get; set; }

        [Required]
        [Column(TypeName = "INT")]
        public int Cantidad_Dias_Tratamiento { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string Comentario { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime Fecha_Real { get; set; }


        public virtual Recorredor Recorredor { get; set; }

        public virtual Integrado Integrado { get; set; }
        public virtual Diagnostico Diagnostico { get; set; }
        public virtual Medicamento Medicamento { get; set; }

    }
}

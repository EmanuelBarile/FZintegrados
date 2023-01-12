using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Medicamento
    {
        [Key]
        [Column(TypeName = "INT")]
        public int Id_Medicamento { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(10)")]
        public string Cod_Producto { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        public string Nombre { get; set; }

        [ForeignKey("Diagnostico")]
        [Column(TypeName = "INT")]
        public int Id_Diagnostico { get; set; }

        public virtual Diagnostico Diagnostico { get; set; }
    }
}

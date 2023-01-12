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
    public class Integrado
    {
        [Key]
        public int Id_Integrado { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(6)")]
        public string Cod_Integrado { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        public string Nombre { get; set; }

        [Column(TypeName = "INT")]
        public int Crianza { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime FechaInicio { get; set; }
    }
}

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
    public class Recorredor
    {

        [Key]
        [Column(TypeName = "INT")]
        public int Id_Recorredor { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(20)")]
        public string Clave { get; set; }

    }
}

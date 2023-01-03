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
    public class Diagnostico
    {
        [Key]
        [Column(TypeName = "INT")]
        public int Id_Diagnostico { get; set; }

        [Required]
        public string Detalle { get; set; }
    }
}

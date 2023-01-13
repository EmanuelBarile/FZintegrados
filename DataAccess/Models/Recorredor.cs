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
                
        public int Id_Recorredor { get; set; }
                
        public string Nombre { get; set; }
                
        public string Clave { get; set; }

    }
}

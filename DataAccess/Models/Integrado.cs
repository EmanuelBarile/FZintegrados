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
        public int Id_Integrado { get; set; }
                
        public string Cod_Integrado { get; set; }

        public string Nombre { get; set; }

        public int Crianza { get; set; }

        public DateTime FechaInicio { get; set; }
    }
}

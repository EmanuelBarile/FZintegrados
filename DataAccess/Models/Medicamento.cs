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
        public int Id_Medicamento { get; set; }
                
        public string Cod_Producto { get; set; }
                
        public string Nombre { get; set; }
                
        public int Id_Diagnostico { get; set; }

        public List<Diagnostico> Diagnosticos { get; set; }

    }
}

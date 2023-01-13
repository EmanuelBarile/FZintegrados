using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class DiagnosticoMedicamento
    {

        public int Diagnostico_Id { get; set; }

        public int Medicamento_Id { get; set; }


        public Diagnostico Diagnostico { get; set; }

        public Medicamento Medicamento { get; set; }


    }
}

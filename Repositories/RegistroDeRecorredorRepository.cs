using Common.DTO;
using Contracts.Repositories;
using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RegistroDeRecorredorRepository : IRegistroDeRecorredorRepository
    {
        private FZIntegradosContext _context { get; set; }

        public RegistroDeRecorredorRepository (FZIntegradosContext context)
        {
            _context = context;
        }

        public void AgregarRegistro(RegistroDeRecorredorDTO registroDeRecorredorDTO)
        {
            _context.RegistrosDeRecorredor.Add(new DataAccess.Models.RegistroDeRecorredor()
            {

                Cod_Integrado = registroDeRecorredorDTO.Cod_Integrado, // desplegar lista de opciones
                Galpon = registroDeRecorredorDTO.Galpon,
                // id diagnostico y medicamento, listas 
                
                 
                Cantidad_Aves= registroDeRecorredorDTO.Cantidad_Aves,
                Cantidad_Medicamento= registroDeRecorredorDTO.Cantidad_Medicamento,
                Cantidad_Dias_Tratamiento= registroDeRecorredorDTO.Cantidad_Dias_Tratamiento,
                Comentario = registroDeRecorredorDTO.Comentario,

            });
        }

        public IList<DiagnosticoDTO> GetAll ()
        {
            return _context.Diagnosticos.Where(x=> x != null).Select(x => new DiagnosticoDTO()
            {
                Detalle= x.Detalle


            }).ToList();

        }
       
    }


}


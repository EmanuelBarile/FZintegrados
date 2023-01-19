using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface IRegistroDeRecorredorRepository
    {
        void AgregarRegistro(RegistroDeRecorredorDTO registroDeRecorredorDTO);
            
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MussalaGateway_Variante.ADO
{
    public record RemovePeripheralDeviceADO
    {
        [Required]
        public Guid Id;
        
    }
}

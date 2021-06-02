using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MussalaGateway_Variante.ADO
{
    public record UpdatePeripheralDeviceADO
    {
        [Required]
        public string Vendor { get; init; }
        
        public bool Status { get; init; }

        public string Photo { get; init; }

        public string GatewayID { get; init; }
    }
}

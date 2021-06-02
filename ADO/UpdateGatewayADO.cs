using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MussalaGateway_Variante.ADO
{
    public record UpdateGatewayADO
    {
        [Required]
        public string SerialNumber { get; init; }
        [Required]
        public string HumanReadableName { get; init; }
        [Required]
        public string IPv4Address { get; init; }
    }
}

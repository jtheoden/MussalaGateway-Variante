using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MussalaGateway_Variante.ADO
{
    public record GatewayADO
    {
        public Guid Id { get; init; }
        public string SerialNumber { get; init; }
        public string HumanReadableName { get; init; }
        public string IPv4Address { get; init; }
    }
    
}

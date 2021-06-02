using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MussalaGateway_Variante.ADO
{
    public record PeripheralDeviceADO
    {
        public Guid Id { get; init; }
        public string Vendor { get; init; }
        public DateTimeOffset DateCreated { get; init; }
        public bool Status { get; init; }
        public string Photo { get; init; }
        public Guid GatewayID { get; init; }
    }
}

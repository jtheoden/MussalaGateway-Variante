using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MussalaGateway_Variante.ADO
{
    public record CreatePeripheralDeviceADO
    {
        public string Vendor { get; init; }

        public bool Status { get; init; }

        public string Photo { get; init; }
    }
}

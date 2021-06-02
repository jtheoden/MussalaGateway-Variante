using Mussala_Gateway_Variante.Models;
using MussalaGateway_Variante.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MussalaGateway_Variante
{
    public static class Extensions
    {
        public static GatewayADO AsADO(this Gateway gateway)
        {
            return new GatewayADO
            {
                Id = gateway.Id,
                HumanReadableName = gateway.HumanReadableName,
                IPv4Address = gateway.IPv4Address,
                SerialNumber = gateway.SerialNumber
            };
        }
        public static PeripheralDeviceADO AsADO(this PeripheralDevice device)
        {
            return new PeripheralDeviceADO
            {
                Id = device.Id,
                Vendor = device.Vendor,
                DateCreated = device.DateCreated,
                Photo = device.Photo,
                Status = device.Status
            };
        }
    }
}

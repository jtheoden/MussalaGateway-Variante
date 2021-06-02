using Mussala_Gateway_Variante.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MussalaGateway_Variante.Repositories
{
    public interface IInMemoryGatewaysRepository
    {
        Task<PeripheralDevice> GetDeviceAsync(Guid id);
        Task<IEnumerable<PeripheralDevice>> GetDevicesAsync();
        Task<Gateway> GetGatewayAsync(Guid id);
        Task<Gateway> GetGatewayBySerialAsync(string serial);
        Task<IEnumerable<Gateway>> GetGatewaysAsync();
        Task CreateGatewayAsync(Gateway gateway);
        Task CreatePeripheralDeviceAsync(PeripheralDevice device);
        Task UpdateGatewayAsync(Gateway gateway);
        Task UpdatePeripheralDeviceAsync(PeripheralDevice device);
        Task RemoveGatewayAsync(Guid id);
        Task RemovePeripheralDeviceAsync(Guid id);
        Task AssignDeviceToGatewayAsync(Guid id, PeripheralDevice device);
        Task<IEnumerable<PeripheralDevice>> GetGatewayDevicesAsync(Guid id);

    }
}
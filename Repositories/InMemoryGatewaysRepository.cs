using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mussala_Gateway_Variante.Models;


namespace MussalaGateway_Variante.Repositories
{
    public class InMemoryGatewaysRepository : IInMemoryGatewaysRepository
    {
        private readonly List<Gateway> gateways = new()
        {
            new Gateway { Id = Guid.Parse("62024270-35f6-4dc8-b2f5-d0749fa29ece"), SerialNumber = "87090833466", HumanReadableName = "Massive Server", IPv4Address = "172.23.42.193" },
            new Gateway { Id = Guid.Parse("2a2c0f8f-afd8-49b9-8231-2c79b5dd465e"), SerialNumber = "87091250833466", HumanReadableName = "Medium Server", IPv4Address = "172.23.42.1" },
            new Gateway { Id = Guid.Parse("2eb9cdc3-5aa5-4c6d-b13d-12b83c8cc68c"), SerialNumber = "256489", HumanReadableName = "Simple Gateway", IPv4Address = "172.23.42.19" },
            new Gateway { Id = Guid.Parse("9a4eff1c-6a0e-4210-ae9a-5e24fe5571e3"), SerialNumber = "876090833466", HumanReadableName = "Red Hat Gate", IPv4Address = "172.23.42.13" },
            new Gateway { Id = Guid.Parse("8f3b11a3-3c68-4e83-88b4-957bc8aaa298"), SerialNumber = "87096980833466", HumanReadableName = "Fedora Gate", IPv4Address = "172.23.42.3" },
            new Gateway { Id = Guid.NewGuid(), SerialNumber = "870905833466", HumanReadableName = "Ubuntu Server", IPv4Address = "172.23.42.93" },
            new Gateway { Id = Guid.NewGuid(), SerialNumber = "8457602963466", HumanReadableName = "Windows Server", IPv4Address = "172.23.42.53" },
            new Gateway { Id = Guid.NewGuid(), SerialNumber = "8758966654", HumanReadableName = "Golden Gate", IPv4Address = "172.23.42.123" },
            new Gateway { Id = Guid.NewGuid(), SerialNumber = "8369514586", HumanReadableName = "Gate Server", IPv4Address = "172.23.42.23" },
            new Gateway { Id = Guid.NewGuid(), SerialNumber = "89811145", HumanReadableName = "Door Server", IPv4Address = "172.23.42.59" },
        };

        private readonly List<PeripheralDevice> devices = new()
        {
            new PeripheralDevice { Id = Guid.NewGuid(), Vendor = "Cisco Systems", Status = true, DateCreated = DateTimeOffset.UtcNow, Photo = "1.png", GatewayID= Guid.Parse("62024270-35f6-4dc8-b2f5-d0749fa29ece") },
            new PeripheralDevice { Id = Guid.NewGuid(), Vendor = "Cisco Systems", Status = true, DateCreated = DateTimeOffset.UtcNow, Photo = "1.png", GatewayID = Guid.Parse("62024270-35f6-4dc8-b2f5-d0749fa29ece") },
            new PeripheralDevice { Id = Guid.NewGuid(), Vendor = "Mussala Soft", Status = true, DateCreated = DateTimeOffset.UtcNow, Photo = "1.png", GatewayID = Guid.Parse("62024270-35f6-4dc8-b2f5-d0749fa29ece") },
            new PeripheralDevice { Id = Guid.NewGuid(), Vendor = "Mussala Soft", Status = true, DateCreated = DateTimeOffset.UtcNow, Photo = "1.png", GatewayID = Guid.Parse("62024270-35f6-4dc8-b2f5-d0749fa29ece") },
            new PeripheralDevice { Id = Guid.NewGuid(), Vendor = "Cisco Systems", Status = true, DateCreated = DateTimeOffset.UtcNow, Photo = "1.png", GatewayID = Guid.Parse("62024270-35f6-4dc8-b2f5-d0749fa29ece") },
            new PeripheralDevice { Id = Guid.NewGuid(), Vendor = "Sun MicroSystems", Status = true, DateCreated = DateTimeOffset.UtcNow, Photo = "1.png", GatewayID = Guid.Parse("2a2c0f8f-afd8-49b9-8231-2c79b5dd465e") },
            new PeripheralDevice { Id = Guid.NewGuid(), Vendor = "Apple Computer", Status = true, DateCreated = DateTimeOffset.UtcNow, Photo = "2.png", GatewayID = Guid.Parse("2a2c0f8f-afd8-49b9-8231-2c79b5dd465e") },
            new PeripheralDevice { Id = Guid.NewGuid(), Vendor = "Alphabet", Status = true, DateCreated = DateTimeOffset.UtcNow, Photo = "3.png", GatewayID = Guid.Parse("2a2c0f8f-afd8-49b9-8231-2c79b5dd465e") },
            new PeripheralDevice { Id = Guid.NewGuid(), Vendor = "Facebook", Status = true, DateCreated = DateTimeOffset.UtcNow, Photo = "4.png", GatewayID = Guid.Parse("2eb9cdc3-5aa5-4c6d-b13d-12b83c8cc68c") },
            new PeripheralDevice { Id = Guid.NewGuid(), Vendor = "VMWare", Status = true, DateCreated = DateTimeOffset.UtcNow, Photo = "1.png", GatewayID = Guid.Parse("2eb9cdc3-5aa5-4c6d-b13d-12b83c8cc68c") },
            new PeripheralDevice { Id = Guid.NewGuid(), Vendor = "Oracle", Status = true, DateCreated = DateTimeOffset.UtcNow, Photo = "1.png", GatewayID = Guid.Parse("2eb9cdc3-5aa5-4c6d-b13d-12b83c8cc68c") },
            new PeripheralDevice { Id = Guid.NewGuid(), Vendor = "Gamesoft", Status = true, DateCreated = DateTimeOffset.UtcNow, Photo = "1.png", GatewayID = Guid.Parse("2eb9cdc3-5aa5-4c6d-b13d-12b83c8cc68c") },
            new PeripheralDevice { Id = Guid.NewGuid(), Vendor = "Rovio", Status = true, DateCreated = DateTimeOffset.UtcNow, Photo = "1.png", GatewayID = Guid.Parse("9a4eff1c-6a0e-4210-ae9a-5e24fe5571e3") },
            new PeripheralDevice { Id = Guid.NewGuid(), Vendor = "Blizzard", Status = true, DateCreated = DateTimeOffset.UtcNow, Photo = "1.png", GatewayID = Guid.Parse("9a4eff1c-6a0e-4210-ae9a-5e24fe5571e3") },
            new PeripheralDevice { Id = Guid.NewGuid(), Vendor = "Nokia", Status = true, DateCreated = DateTimeOffset.UtcNow, Photo = "1.png", GatewayID = Guid.Parse("8f3b11a3-3c68-4e83-88b4-957bc8aaa298") },
            new PeripheralDevice { Id = Guid.NewGuid(), Vendor = "Xiaomi", Status = true, DateCreated = DateTimeOffset.UtcNow, Photo = "1.png", GatewayID = Guid.Parse("8f3b11a3-3c68-4e83-88b4-957bc8aaa298") },
            new PeripheralDevice { Id = Guid.NewGuid(), Vendor = "Mussala Soft", Status = true, DateCreated = DateTimeOffset.UtcNow, Photo = "1.png", GatewayID = Guid.Parse("8f3b11a3-3c68-4e83-88b4-957bc8aaa298") },
            new PeripheralDevice { Id = Guid.NewGuid(), Vendor = "Mussala Soft", Status = true, DateCreated = DateTimeOffset.UtcNow, Photo = "1.png", GatewayID = Guid.Parse("8f3b11a3-3c68-4e83-88b4-957bc8aaa298") },
            new PeripheralDevice { Id = Guid.NewGuid(), Vendor = "Mussala Soft", Status = true, DateCreated = DateTimeOffset.UtcNow, Photo = "1.png", GatewayID = Guid.Parse("8f3b11a3-3c68-4e83-88b4-957bc8aaa298") },
            new PeripheralDevice { Id = Guid.NewGuid(), Vendor = "Mussala Soft", Status = true, DateCreated = DateTimeOffset.UtcNow, Photo = "1.png", GatewayID = Guid.Parse("8f3b11a3-3c68-4e83-88b4-957bc8aaa298") },
        };

        public async Task<IEnumerable<Gateway>> GetGatewaysAsync()
        {
            return await Task.FromResult(gateways);
        }

        public async Task<Gateway> GetGatewayAsync(Guid id)
        {
            return await Task.FromResult(gateways.Where(gateway => gateway.Id == id).SingleOrDefault());
        }
        public async Task<Gateway> GetGatewayBySerialAsync(string serial)
        {
            return await Task.FromResult(gateways.Where(gateway => gateway.SerialNumber == serial).SingleOrDefault());
        }
        public async Task<IEnumerable<PeripheralDevice>> GetGatewayDevicesAsync(Guid id)
        {
            return await Task.FromResult(devices.Where(device => device.GatewayID == id));
        }
        public async Task<IEnumerable<PeripheralDevice>> GetDevicesAsync()
        {
            return await Task.FromResult( devices);
        }

        public async Task<PeripheralDevice> GetDeviceAsync(Guid id)
        {
            return await Task.FromResult(devices.Where(device => device.Id == id).SingleOrDefault());
        }

        public async Task CreateGatewayAsync(Gateway gateway)
        {
            gateways.Add(gateway);
            await Task.CompletedTask;
        }

        public async Task CreatePeripheralDeviceAsync(PeripheralDevice device)
        {
            devices.Add(device);
            await Task.CompletedTask;
        }

        public async Task UpdateGatewayAsync(Gateway gateway)
        {
            var index = gateways.FindIndex(existingGateway => existingGateway.Id == gateway.Id);
            gateways[index] = gateway;
            await Task.CompletedTask;
        }

        public async Task UpdatePeripheralDeviceAsync(PeripheralDevice device)
        {
            var index = devices.FindIndex(existingDevice => existingDevice.Id == device.Id);
            devices[index] = device;
            await Task.CompletedTask;
        }

        public async Task RemoveGatewayAsync(Guid id)
        {
            var index = gateways.FindIndex(existingGateway => existingGateway.Id == id);
            gateways.RemoveAt(index);
            await Task.CompletedTask;
        }

        public async Task RemovePeripheralDeviceAsync(Guid id)
        {
            var index = devices.FindIndex(existingDevice => existingDevice.Id == id);
            devices.RemoveAt(index);
            await Task.CompletedTask;
        }

        public async Task AssignDeviceToGatewayAsync(Guid id_gateway, PeripheralDevice device)
        {
            var gate=gateways.Find(existingGateway => existingGateway.Id == id_gateway);
            devices.Add(device with { GatewayID=gate.Id});
            await Task.CompletedTask;
        }
    }
}

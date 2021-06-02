using Microsoft.AspNetCore.Mvc;
using Mussala_Gateway_Variante.Models;
using MussalaGateway_Variante.ADO;
using MussalaGateway_Variante.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MussalaGateway_Variante.Controllers
{
    //GET /gatewayclient/gateways
    [ApiController]
    [Route("/gatewayclient/gateways")]
    public class GatewayController : ControllerBase
    {
        private readonly IInMemoryGatewaysRepository repository;

        public GatewayController(IInMemoryGatewaysRepository repository)
        {
            this.repository = repository;
        }

        //GET /gateways
        [HttpGet]
        public async Task<IEnumerable<GatewayADO>> GetGatewaysAsync()
        {
            var gateways = (await repository.GetGatewaysAsync())
                .Select(gateway=>gateway.AsADO());
            return gateways;
        }

        //GET /gateways/{id}
        [HttpGet("/gatewayclient/gateways/{id}")]
        public async Task<ActionResult<GatewayADO>> GetGatewayAsync(Guid id)
        {
            var gateway = await repository .GetGatewayAsync(id);

            if (gateway is null)
            {
                return NotFound();
            }

            return gateway.AsADO();
        }
        //GET /gateways/serie/{serial}
        [HttpGet("/gatewayclient/gateways/serie/{serial}")]
        public async Task<ActionResult<GatewayADO>> GetGatewayBySerialAsync(string serial)
        {
            var gateway = await repository.GetGatewayBySerialAsync(serial);
            if (gateway is null)
            {
                return NotFound();
            }

            return gateway.AsADO();
        }
        //POST /gateways
        [Route("/gateways"),HttpPost]
        public async Task<ActionResult<GatewayADO>> CreateGatewayAsync(CreateGatewayADO gatewayADO)
        {
            Gateway gateway = new()
            {
                Id = Guid.NewGuid(),
                HumanReadableName = gatewayADO.HumanReadableName,
                IPv4Address = gatewayADO.IPv4Address,
                SerialNumber = gatewayADO.SerialNumber
            };
            await repository.CreateGatewayAsync(gateway);
            return CreatedAtAction(nameof(GetGatewayAsync), new { id = gateway.Id }, gateway.AsADO());
        }
        //POST /gateways/{id}/devices
        [HttpPost("/gatewayclient/gateways/{id}/devices")]
        public async Task<ActionResult<PeripheralDeviceADO>> AssignDeviceToGatewayAsync([FromRoute] Guid id, AssignDeviceToGatewayADO deviceADO)
        {
            PeripheralDevice device = new()
            {
                Id = Guid.NewGuid(),
                Vendor = deviceADO.Vendor,
                Photo = deviceADO.Photo,
                Status = deviceADO.Status,
                DateCreated = DateTimeOffset.UtcNow,
                GatewayID=id
            };
            var devices = await repository.GetGatewayDevicesAsync(id);
            if(devices.Count()<10)
            {
                await repository.AssignDeviceToGatewayAsync(id, device);
                return CreatedAtAction(nameof(PeripheralDeviceController.GetDeviceAsync), new { id = device.Id }, device.AsADO());
            }
            throw new Exception("It is not allowed to attach more than 10 device to a gateway");

            
        }
        //GET /gateways/{id}/devices
        [Route("/gateways/{id}/devices"),HttpGet("/gatewayclient/gateways/{id}/devices")]
        public async Task<IEnumerable<PeripheralDeviceADO>> GetGatewayDevicesAsync([FromRoute] Guid id)
        {
            var gateway = await repository.GetGatewayAsync(id);

            if (gateway is null)
            {
                return null;
            }

            var devices = (await repository.GetGatewayDevicesAsync(gateway.Id))
                .Select(device => device.AsADO());
            return devices; 
        }
        //PUT /gateways/{id}
        [Route("gateways/{id}"), HttpPut("{id}")]
        public async Task<ActionResult> UpdateGatewayAsync([FromRoute] Guid id, UpdateGatewayADO gatewayADO)
        {
            var existingGateway = await repository .GetGatewayAsync(id);
            if (existingGateway is null)
            {
                return NotFound();
            }

            Gateway updatedGateway = existingGateway with { 
                HumanReadableName =gatewayADO.HumanReadableName,
                IPv4Address = gatewayADO.IPv4Address,
                SerialNumber =gatewayADO.SerialNumber
            };
            await repository .UpdateGatewayAsync(updatedGateway);
            return NoContent();
        }
        //DELETE /gateways/{id}
        [Route("gateways/{id}"),HttpDelete("{id}")]
        public async Task<ActionResult> RemoveGateway([FromRoute]Guid id)
        {
            var existingGateway = await repository .GetGatewayAsync(id);
            if (existingGateway is null)
            {
                return NotFound();
            }
            await repository .RemoveGatewayAsync(id);
            return NoContent();
        }


    }
}

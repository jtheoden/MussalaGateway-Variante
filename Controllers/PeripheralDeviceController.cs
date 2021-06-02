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
    //GET /gatewayclient/devices
    [ApiController]
    [Route("/gatewayclient/devices")]
    public class PeripheralDeviceController:ControllerBase
    {
        private readonly IInMemoryGatewaysRepository repository;

        public PeripheralDeviceController(IInMemoryGatewaysRepository repository)
        {
            this.repository = repository;
        }
        //GET /devices
        [HttpGet]
        public async Task<IEnumerable<PeripheralDeviceADO>> GetPeripheralDevicesAsync()
        {
            var devices = (await repository.GetDevicesAsync())
                .Select(device => device.AsADO());
            return devices;
        }

        //GET /devices/{id}
        [HttpGet("/gatewayclient/devices/{id}")]
        public async Task<ActionResult<PeripheralDeviceADO>> GetDeviceAsync(Guid id)
        {
            var device = await repository.GetDeviceAsync(id);

            if (device is null)
            {
                return NotFound();
            }

            return device.AsADO();
        }
        //POST /devices
        [HttpPost]
        public async Task<ActionResult<PeripheralDeviceADO>> CreatePeripheralDeviceAsync(CreatePeripheralDeviceADO deviceADO)
        {
            PeripheralDevice device = new()
            {
                Id = Guid.NewGuid(),
                Vendor = deviceADO.Vendor,
                Photo = deviceADO.Photo,
                Status = deviceADO.Status,
                DateCreated = DateTimeOffset.UtcNow
                
            };
            await repository.CreatePeripheralDeviceAsync(device);
            return CreatedAtAction(nameof(GetDeviceAsync), new { id = device.Id }, device.AsADO());
        }

        //PUT /devices/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePeripheralDeviceAsync(Guid id, UpdatePeripheralDeviceADO deviceADO)
        {
            var existingDevice = await repository .GetDeviceAsync(id);
            if (existingDevice is null)
            {
                return NotFound();
            }

            PeripheralDevice updatedDevice = existingDevice with
            {
                Photo = deviceADO.Photo,
                Status = deviceADO.Status,
                Vendor = deviceADO.Vendor
            };
            await repository.UpdatePeripheralDeviceAsync(updatedDevice);
            return NoContent();
        }
        //DELETE /devices/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> RemovePeripheralDeviceAsync(Guid id)
        {
            var existingDevice = await repository.GetDeviceAsync(id);
            if (existingDevice is null)
            {
                return NotFound();
            }
            await repository .RemovePeripheralDeviceAsync(id);
            return NoContent();
        }

    }
}

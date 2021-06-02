using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Mussala_Gateway_Variante.Models
{
    public record Gateway
    {
        public Guid Id { get; init; }
        public string SerialNumber { get; init; }
        public string HumanReadableName { get; init; }
        public string IPv4Address { get; init; }
        /*[Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        private string serial_number;
        [Column(TypeName = "nvarchar(50)")]
        private string human_readable_name;
        [Column(TypeName = "nvarchar(16)")]
        private string ipv4_address;//to be validated

        private List<PeripheralDevice> peripheral_devices;

        public string Serial_number { get => serial_number; set => serial_number = value; }
        public string Human_readable_name { get => human_readable_name; set => human_readable_name = value; }
        public string IPv4_address { get => ipv4_address; set => ipv4_address = value; }

        // public DateTime cer { get => ipv4_address; set => ipv4_address = value; }
        public List<PeripheralDevice> Periferal_devices { get => peripheral_devices; set => peripheral_devices = value; }
        */

    }
}

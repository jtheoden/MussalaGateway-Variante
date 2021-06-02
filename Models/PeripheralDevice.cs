using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mussala_Gateway_Variante.Models
{
    public record PeripheralDevice
    {
        
        public Guid Id { get; init; }
        
        public string Vendor { get; init; }
        
        public DateTimeOffset DateCreated { get; init; }
        
       public bool Status { get; init; }

        
        public string Photo { get; init; }
        
        public Guid GatewayID { get; init; }
    }
   

}







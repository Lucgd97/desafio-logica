using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa.Models
{
    public record ContaCorrente
    {
        public required string IdCliente { get; set; }
        public double Valor { get; set; } = default!;
        public DateTime Data { get; set; } = default!;
    }
}

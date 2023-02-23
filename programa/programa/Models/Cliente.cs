using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa.Models
{
    public record Cliente
    {
        public required string Id { get; set; } = default!;
        public string Nome { get; set; } = default!;
        public string Telefone { get; set; } = default!;
        public string Email { get; set; } = default!;
    }
}
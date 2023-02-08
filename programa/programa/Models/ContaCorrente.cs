using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa.Models
{
    public struct ContaCorrente
    {
        public string IdCliente { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
    }
}

using Programa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa.Servicos
{
    class ClienteServico
    {
        private ClienteServico() { }

        private static ClienteServico instnacia = default!;

        public static ClienteServico Get()
        {
            if (instnacia == null) instnacia = new ClienteServico();
            return instnacia;
        }

        public List<Cliente> Lista = new List<Cliente>();
    }
}

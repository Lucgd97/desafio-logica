using Programa.Infra.Interfaces;
using Programa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa.Servicos
{
    public class ClienteServico
    {
        public IPersistencia<Cliente> Persistencia;

        public ClienteServico(IPersistencia<Cliente> persistencia) 
        {
            this.Persistencia = persistencia;            
        }


    }
}

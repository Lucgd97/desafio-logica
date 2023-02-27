using Programa.Infra.Interfaces;
using Programa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa.Servicos
{
    public class ContaCorrenteServico
    {
        public IPersistencia<ContaCorrente> Persistencia;

        public ContaCorrenteServico(IPersistencia<ContaCorrente> persistencia) 
        {
            this.Persistencia = persistencia;            
        }

        public async Task<List<ContaCorrente>> ExtratoCliente(string idCliente)
        {
            var contaCorreteCliente = (await this.Persistencia.Todos()).FindAll(cc => cc.IdCliente == idCliente);
            if (contaCorreteCliente.Count == 0) return new List<ContaCorrente>();

            return contaCorreteCliente;
        }

        public async Task<double> SaldoCliente(string idCliente, List<ContaCorrente>? contaCorreteCliente = null)
        {
            if (contaCorreteCliente == null)
                contaCorreteCliente = await ExtratoCliente(idCliente);

            if (contaCorreteCliente.Count == 0) return 0;

            return Convert.ToDouble(contaCorreteCliente.Sum(cc => cc.Valor));
        }


    }
}


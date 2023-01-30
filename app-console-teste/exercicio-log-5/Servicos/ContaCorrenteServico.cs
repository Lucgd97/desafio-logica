using Logica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Servicos
{
    class ContaCorrenteServico
    {
        private ContaCorrenteServico() { }

        private ContaCorrenteServico instancia;

        private List<ContaCorrente> contaCorrente = new List<ContaCorrente>();

        public List<ContaCorrente> extratoCliente(string idCliente)
        {
            var contaCorreteCliente = contaCorrente.FindAll(cc => cc.IdCliente == idCliente);
            if (contaCorreteCliente.Count == 0) return new List<ContaCorrente>();

            return contaCorreteCliente;
        }

        public double saldoCliente(string idCliente, List<ContaCorrente>? contaCorreteCliente = null)
        {
            if (contaCorreteCliente == null)
                contaCorreteCliente = extratoCliente(idCliente);

            if (contaCorreteCliente.Count == 0) return 0;

            return Convert.ToDouble(contaCorreteCliente.Sum(cc => cc.Valor));
        }


    }
}

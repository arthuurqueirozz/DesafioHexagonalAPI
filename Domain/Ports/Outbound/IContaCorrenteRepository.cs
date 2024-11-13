using Adapters.Domain.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Ports.Outbound
{
    public interface IContaCorrenteRepository
    {
        public void AbrirContaCorrente(ContaCorrente contaCorrente);
    }
}

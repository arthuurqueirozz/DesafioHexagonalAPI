using Adapters.Domain.Core.Models.Entities;
using Domain.Ports.Inbound;
using Domain.Ports.Outbound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.AbrirContaCorrente
{
    public class UscAbrirContaCorrente : IUscAbrirContaCorrente
    {
        private readonly IContaCorrenteRepository _contaRepository;
        private readonly ILogAbrirContaCorrenteRepository _logRepository;

        public UscAbrirContaCorrente(IContaCorrenteRepository contaReporitory, ILogAbrirContaCorrenteRepository logRepository)
        {
            _contaRepository =  contaReporitory ; 
            _logRepository = logRepository;
        }

        public Task<ContaCorrente> ExecutarTransacao()
        {
            throw new NotImplementedException();
        }
    }
}

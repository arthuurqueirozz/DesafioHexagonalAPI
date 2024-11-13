using Adapters.Domain.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Ports.Inbound
{
    public interface IUscAbrirContaCorrente
    {
        Task<ContaCorrente> ExecutarTransacao();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Ports.Outbound
{
    public interface ILogAbrirContaCorrenteRepository
    {
        public void RegistrarLog(string mensagem);
    }
}

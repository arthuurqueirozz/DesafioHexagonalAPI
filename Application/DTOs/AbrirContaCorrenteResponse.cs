using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    internal class AbrirContaCorrenteResponse
    {
        public int NumeroContaCorrente { get; set; }
        public int Agencia { get; set; }
        public string mensagem { get; set; }
    }
}

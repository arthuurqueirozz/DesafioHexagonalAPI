using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class AbrirContaCorrenteRequest
    {
        public string Nome { get; set; }
        public DateOnly Nascimento { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}

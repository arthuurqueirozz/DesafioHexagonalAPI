namespace Adapters.Domain.Core.Models.Entities
{
    public record ContaCorrente
    {

        public string Nome { get; set; }
        public DateOnly Nascimento { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public int NumeroConta { get;  set; }
        public int Agencia { get; set; }
        public string Senha { get; set; }

        public ContaCorrente()
        {

        }

        public ContaCorrente(string nome, DateOnly nascimento, string cpf, string senha, string email = "")
        {

            if (!ValidarIdade(nascimento))
                throw new ArgumentException("Cliente deve ser maior de 17 anos.");

            if (!ValidarSenha(senha))
                throw new ArgumentException("A senha deve conter exatamente 6 dígitos únicos.");


            this.Nome = nome;
            this.Nascimento = nascimento;
            this.CPF = cpf;
            this.Email = email;
            this.Senha = senha;


            this.Agencia = new Random().Next(10, 1000);
            this.NumeroConta = new Random(int.Parse(cpf)).Next(1500, 100000) + new Random(int.Parse(cpf)).Next(1, 100);

        }

        private static bool ValidarIdade(DateOnly nascimento)
        {
            DateOnly hoje = DateOnly.FromDateTime(DateTime.Today);
            int idade = hoje.Year - nascimento.Year;

            if (nascimento > hoje.AddYears(-idade))
                idade--;

            return idade >= 18;
        }


        private static bool ValidarSenha(string senha)
        {
            return senha.Length == 6
                   && senha.All(char.IsDigit)
                   && senha.Distinct().Count() == 6;
        }

    }
}

using Adapters.Domain.Core.Models.Entities;
using Domain.Ports.Outbound;
using Microsoft.Data.SqlClient;
using System.Data;


namespace Infrastructure.Repositories.UscRepositories
{
    public class ContaCorrenteRepository : IContaCorrenteRepository
    {
        private IDbConnection _connection;
        public void AbrirContaCorrente(ContaCorrente contaCorrente)
        {
            _connection = new SqlConnection("");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reformation.Models;

namespace Reformation.Repositories.TransactionRepository
{
    public class TransactionRepository : ITransactionRepository
    {
        public Task<TransactionModel> AddTransaction(TransactionModel transaction)
        {
            throw new NotImplementedException();
        }

        public Task<TransactionModel> DeleteTransaction(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TransactionModel> GetTransaction(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TransactionModel>> GetTransactions()
        {
            throw new NotImplementedException();
        }

        public Task<TransactionModel> UpdateTransaction(TransactionModel transaction)
        {
            throw new NotImplementedException();
        }
    }
}
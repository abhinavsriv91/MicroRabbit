using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDBContext _ctx;

        public TransferRepository(TransferDBContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<TransferLogs> GetTransferLogs()
        {
            return _ctx.TransferLogs;
        }

        public void Add(TransferLogs transferLogs)
        {
            _ctx.Add(transferLogs);
            _ctx.SaveChanges();
        }
    }
}

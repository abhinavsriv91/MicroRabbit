using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Application.Services
{
    public class TransferServices : ITransferServices
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus;


        public TransferServices(ITransferRepository transferRepository, IEventBus bus)
        {
            _transferRepository = transferRepository;
            _bus = bus;
        }

        public IEnumerable<TransferLogs> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }
    }
}

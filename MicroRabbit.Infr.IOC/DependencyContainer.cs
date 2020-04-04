using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Infr.IOC
{
    public class DependencyContainer
    {
        public static void Register(IServiceCollection services) 
        {
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Data.Context
{
    public class BankingDBContextFactory : IDesignTimeDbContextFactory<BankingDBContext>
    {
        public BankingDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BankingDBContext>();
            optionsBuilder.UseSqlServer("Data Source=EQ-EQ6289360;Database=BankingDB;user id=sa;password=sa@2020;");

            return new BankingDBContext(optionsBuilder.Options);
        }
    }
}

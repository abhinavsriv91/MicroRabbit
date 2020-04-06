using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MicroRabbit.Transfer.Data.Context
{
    public class TransferDBContextFactory : IDesignTimeDbContextFactory<TransferDBContext>
    {
        public TransferDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TransferDBContext>();
            optionsBuilder.UseSqlServer("Data Source=EQ-EQ6289360;Database=TransferDB;user id=sa;password=sa@2020;");

            return new TransferDBContext(optionsBuilder.Options);
        }
    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetoAcademia.Domain.Entities.Account;
using ProjetoAcademia.Infra.Data.DataConfig;

namespace ProjetoAcademia.Infra.Data.Context
{
    public class DataContext : IdentityDbContext<Users>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Users>(new UsersConfiguration().Configure);
            base.OnModelCreating(mb);
        }
    }
}

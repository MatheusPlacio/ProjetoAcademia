using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoAcademia.Domain.Entities.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademia.Infra.Data.DataConfig
{
    public class UsersConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("Users");

            builder.Property(x => x.FirstName)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.LastName)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.UserName)
                .HasColumnType("varchar(50)")
                .IsRequired();
        }
    }
}

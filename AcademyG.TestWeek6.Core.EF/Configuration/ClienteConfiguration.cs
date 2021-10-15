using AcademyG.TestWeek6.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyG.TestWeek6.Core.EF.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.Property(c => c.CodiceCliente).HasMaxLength(5).IsRequired();
            builder.Property(c => c.Nome).HasMaxLength(50).IsRequired();
            builder.Property(c => c.Cognome).HasMaxLength(50).IsRequired();
            builder.HasMany(o => o.Ordini).WithOne(c => c.Cliente);
        }
    }
}

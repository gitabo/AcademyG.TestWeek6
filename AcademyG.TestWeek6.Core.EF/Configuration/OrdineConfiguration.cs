using AcademyG.TestWeek6.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyG.TestWeek6.Core.EF.Configuration
{
    public class OrdineConfiguration : IEntityTypeConfiguration<Ordine>
    {
        public void Configure(EntityTypeBuilder<Ordine> builder)
        {
            builder.Property(o => o.CodiceOrdine).HasMaxLength(5).IsRequired();
            builder.Property(o => o.CodiceProdotto).HasMaxLength(5).IsRequired();
            builder.Property(o => o.DataOrdine).IsRequired();
            builder.Property(o => o.Importo).HasColumnType("decimal(6,2)").IsRequired();
            builder.HasOne(c => c.Cliente).WithMany(o => o.Ordini);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramApp.DataEntity.Models.Map
{
    public class ReferralMap : IEntityTypeConfiguration<Referral>
    {
        public void Configure(EntityTypeBuilder<Referral> builder)
        {
            builder.ToTable("tbl_Referral");
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id)
                .HasMaxLength(50)
                .HasColumnName("Id")
                .IsRequired();

            builder.Property(p => p.Referrer)
                .HasMaxLength(255)
                .HasColumnName("Referrer")
                .IsRequired();

            builder.Property(p => p.Referee)
                .HasMaxLength(255)
                .HasColumnName("Referee")
                .IsRequired();

            builder.Property(p => p.Point)
                .HasMaxLength(255)
                .HasColumnName("point")
                .HasColumnType("decimal(18,2)")
                .IsRequired();
        }
    }
}

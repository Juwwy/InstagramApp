using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramApp.DataEntity.Models.Map
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("tbl_User");
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id)
                .HasMaxLength(255)
                .HasColumnName("UserId")
                .IsRequired();

            builder.Property(p => p.Firstname)
                .HasColumnName("FirstName")
                .HasMaxLength(125)
                .IsRequired();

            builder.Property(p => p.Lastname)
                .HasColumnName("Lastname")
                .HasMaxLength(125)
                .IsRequired();

            builder.Property(p => p.Username)
                .HasColumnName("Username")
                .HasMaxLength(125)
                .IsRequired();

            builder.Property(p => p.Email)
                .HasColumnName("Email")
                .HasMaxLength(125)
                .IsRequired();

            builder.Property(p => p.Password)
                .HasColumnName("Password")
                .HasMaxLength(125)
                .IsRequired();

            builder.Property(p => p.Telephone)
                .HasColumnName("Telephone")
                .HasMaxLength(125)
                .IsRequired();

            builder.Property(p => p.ReferralCode)
                .HasColumnName("ReferralCode")
                .HasMaxLength(125)
                .IsRequired(false);

            builder.Property(p => p.FcmToken)
                .HasColumnName("FcmToken")
                .HasMaxLength(125)
                .IsRequired(false);

            builder.Property(p => p.WalletBalance)
                .HasColumnName("WalletBalance")
                .HasColumnType("decimal(18,2)")
                .HasMaxLength(125)
                .IsRequired();




        }
    }
}

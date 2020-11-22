using Hff.Challenge.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Challenge.DataAccess.Concrete.Mappings
{
    public class AppUserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Surname).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Password).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(50).IsRequired();




        }
    }
}

﻿using Hff.MembershipServer.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.MembershipServer.Service.Concrete.Data.Mapping
{
    public class AppRoleMap : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasKey(prop => prop.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
        }
    }
}

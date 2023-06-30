using Domain.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations
{
    public class TodoListConfigurations : BaseEntityConfiguration<TodoWork>
    {
        public override void Configure(EntityTypeBuilder<TodoWork> builder)
        {

            builder.Property(x => x.TimeStart)
                .IsRequired(false)
                .HasMaxLength(100)
                .IsUnicode()
                .HasColumnType("datetime");

            builder.Property(x => x.TimeEnd)
                .IsRequired(false)
                .HasMaxLength(100)
                .IsUnicode()
                .HasColumnType("datetime");

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode()
                .HasColumnType("nvarchar");

            builder.Property(x => x.Description)
                .IsRequired(false )
                .HasMaxLength(1000)
                .IsUnicode()
                .HasColumnType("nvarchar");
            builder.Property(x => x.IsComplete)
                .IsRequired(false)
                .HasMaxLength(50)
                .IsUnicode()
                .HasColumnType("nvarchar");

            base.Configure(builder);
        }
    }
}

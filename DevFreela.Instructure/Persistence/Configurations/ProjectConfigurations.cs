using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Instructure.Persistence.Configurations
{
    public class ProjectConfigurations : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            //Cria a tabela project
            builder
                 .HasKey(p => p.Id);
            //Define coluna e dados freelancer
            builder
                 .HasOne(p => p.FreeLancer)
                .WithMany(f => f.FreelanceProjects)
                .HasForeignKey(p => p.IdFreelancer)
                .OnDelete(DeleteBehavior.Restrict);
            //Defina coluna e dados cliente
            builder
                .HasOne(p => p.Client)
               .WithMany(f => f.OwnedProjects)
               .HasForeignKey(p => p.IdClient)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

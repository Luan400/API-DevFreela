using DevFreela.Core.Entities;
using DevFreela.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DevFreela.UnitTests.Core.Entities
{
  public class ProjectTest
    {
        [Fact]

        public void TestIfProjectStartWorks () {

            var project = new Project("Titulo", "Descrição", 12, 13, 10000);

            Assert.Equal(ProjectStatusEnum.Created, project.Status);
           

            Assert.NotEmpty(project.Title);
            Assert.NotNull(project.Title);

            Assert.NotEmpty(project.Description);
            Assert.NotNull(project.Description);

            project.Start();

            Assert.Equal(ProjectStatusEnum.InProgress, project.Status);
            Assert.NotNull(project.StartedAt);



        }
    }
}

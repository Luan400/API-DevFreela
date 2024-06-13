using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Repositories
{
    public interface IProjectRepository
    {

        Task<Project> GetDetailsByIdAsync(int id);


        Task<List<Project>> GetAllAsync();

        Task<Project> GetByIdAsync(int id);

        Task AddAsync(Project project);

        Task StartAsync(int id);

        Task SaveChangesAsync();

        Task AddCommentAsync(ProjectComment projectComment);


      
    }
}

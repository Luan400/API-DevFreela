using DevFreela.Core.Repositories;
using DevFreela.Instructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.Start
{
    public class StartCommandHandler : IRequestHandler<StartCommand, Unit>
    {
        private readonly IProjectRepository _projectRepository;

        public StartCommandHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<Unit> Handle(StartCommand request, CancellationToken cancellationToken)
        {

            await _projectRepository.StartAsync(request.Id);
            return Unit.Value;
        }
    }
}

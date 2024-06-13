﻿using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Instructure.Persistence.Repositories
{
    public class SkillRepository : ISkillRepository
    {
        private readonly DevFreelaDbContext _dbContext;

        public SkillRepository(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        public async Task<List<Skill>> GetAll()
        {
            return await _dbContext.Skills.ToListAsync();
        }

        public Task<List<Skill>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}

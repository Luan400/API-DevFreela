using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
   public class SkillViewModel
    {
        public SkillViewModel(int id, string descriptions)
        {
            Id = id;
            Descriptions = descriptions;
        }

        public int Id { get; private set; }

        public string Descriptions { get; private set; }
    }
}

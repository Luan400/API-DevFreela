using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
   public class ProjectDetaisViewModel
    {
        public ProjectDetaisViewModel(int id, string title, string description, decimal totalCost, DateTime startedAt, DateTime finishedAt, string clientFullName, string freelancerFullName)
        {
            Id = id;
            Title = title;
            Description = description;
            StartedAt = startedAt;
            FinishedAt = finishedAt;
            TotalCost = totalCost;
            ClientFullName = clientFullName;
            FreeLancerFullName = freelancerFullName;
        }

        public int Id { get; private set; }

        public string  Title { get; private set; }

        public string Description { get; private set; }
        public decimal TotalCost { get; private set; }

        public DateTime StartedAt { get; private set; }

        public DateTime FinishedAt { get; private set; }

        public string ClientFullName { get; private set; }

        public string FreeLancerFullName { get; private set; }


    }
}

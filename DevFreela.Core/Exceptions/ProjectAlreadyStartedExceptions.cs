using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Exceptions
{
    public class ProjectAlreadyStartedExceptions : Exception
    {

        public ProjectAlreadyStartedExceptions() : base("Project is already stated")
        {
            
        }
    }
}

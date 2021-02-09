using Example.Persistence.Repositories.DeveloperRepository;
using Example.Persistence.Repositories.ProjectRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Persistence.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IDeveloperRepository Developers { get; }
        IProjectRepository Projects { get; }
        int Complete();
    }
}

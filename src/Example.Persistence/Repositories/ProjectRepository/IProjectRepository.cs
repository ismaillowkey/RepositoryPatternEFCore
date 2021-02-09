using Example.Domain.Entities;
using Example.Persistence.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Persistence.Repositories.ProjectRepository
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
    }
}

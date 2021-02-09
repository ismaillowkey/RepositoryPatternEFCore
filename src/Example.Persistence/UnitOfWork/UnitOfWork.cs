using Example.Persistence.Contexts;
using Example.Persistence.Repositories.DeveloperRepository;
using Example.Persistence.Repositories.ProjectRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Developers = new DeveloperRepository(_context);
            Projects = new ProjectRepository(_context);
        }
        public IDeveloperRepository Developers { get; private set; }
        public IProjectRepository Projects { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            //GC.SuppressFinalize(_context);
            _context.Dispose();
        }
    }
}

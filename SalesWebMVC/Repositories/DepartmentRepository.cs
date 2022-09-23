using SalesWebMVC.Repositories.Interface;
using SalesWebMVC.Data;
using SalesWebMVC.Models;



namespace SalesWebMVC.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
            private readonly SalesWebMVCContext _context;

            public DepartmentRepository(SalesWebMVCContext context)
            {
                _context = context;
            }

            public IEnumerable<Department> Departments => _context.Department;
        
    }
}

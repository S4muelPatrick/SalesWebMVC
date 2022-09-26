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

        public void Seed()
        {
            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

        }

            public IEnumerable<Department> Departments => _context.Department;
        
    }
}

using SalesWebMVC.Data;
using SalesWebMVC.Models;

namespace SalesWebMVC.Repositories.Interface
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> Departments { get; }

    }
}

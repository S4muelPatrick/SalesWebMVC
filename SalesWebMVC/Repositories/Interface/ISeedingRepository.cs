using SalesWebMVC.Models;

namespace SalesWebMVC.Repositories.Interface
{
    public interface ISeedingRepository
    {
        IEnumerable<SeedingService> seedingServices { get; }

    }
}

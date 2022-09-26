using SalesWebMVC.Models;

namespace SalesWebMVC.Repositories.Interface
{
    public interface ISalesRecordRepository
    {
        IEnumerable<SalesRecord> salesRecords { get; }
    }
}

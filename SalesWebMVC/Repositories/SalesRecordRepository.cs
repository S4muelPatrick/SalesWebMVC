using Microsoft.AspNetCore.Mvc.ViewFeatures;
using SalesWebMVC.Data;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;
using SalesWebMVC.Repositories.Interface;

namespace SalesWebMVC.Repositories
{
    public class SalesRecordRepository : ISalesRecordRepository
    {
        private readonly SalesWebMVCContext _context;

        public SalesRecordRepository(SalesWebMVCContext context)
        {
            _context = context;
        }

       
        public IEnumerable<SalesRecord> salesRecords => _context.SalesRecord;
    }
    

           

    
}

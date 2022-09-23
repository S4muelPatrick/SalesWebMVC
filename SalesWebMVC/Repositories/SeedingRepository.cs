using SalesWebMVC.Repositories.Interface;
using SalesWebMVC.Data;
using System;
using SalesWebMVC.Models;

namespace SalesWebMVC.Repositories
{
    public class SeedingRepository : ISeedingRepository
    {
        private readonly SalesWebMVCContext _context;

        public SeedingRepository(SalesWebMVCContext context)
        {
            _context = context;
        }

        public IEnumerable<SeedingService> seedingServices => _context.seedingServices;
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Data;
using SalesWebMVC.Models;
using SalesWebMVC.Repositories.Interface;

namespace SalesWebMVC.Repositories
{
    public class SellerRepository : ISellerRepository
    {
        private readonly SalesWebMVCContext _context;
        public SellerRepository(SalesWebMVCContext context)
        {
            _context = context;
        }

       
        IEnumerable<Seller> Sellers => _context.Seller;

        IEnumerable<Seller> ISellerRepository.Sellers => _context.Seller;
        /* public IEnumerable<Seller> Sellers => _context.Seller.Include(c => c.seller);
public GetSellerById(int id)
{

}*/


    }
}

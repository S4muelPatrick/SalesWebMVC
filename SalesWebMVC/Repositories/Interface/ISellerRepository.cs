using SalesWebMVC.Models;
using System.Security.Permissions;

namespace SalesWebMVC.Repositories.Interface
{
    public interface ISellerRepository
    {
        IEnumerable<Seller> Sellers { get; }

        //Seller GetSellerById(int Id);
    }
}

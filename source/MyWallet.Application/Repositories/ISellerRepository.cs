using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RePro.Domain.Sellers;
namespace RePro.Application.Repositories
{
    public interface ISellerRepository
    {
        Task<Seller> Get(int sellerId);
        Task Add(Seller seller);
        Task Update(Seller seller);
    }
}


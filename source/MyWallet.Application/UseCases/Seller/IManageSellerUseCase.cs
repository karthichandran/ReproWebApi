using System.Threading.Tasks;
using System;

namespace RePro.Application.UseCases.Seller
{
    public interface IManageSellerUseCase
    {
        Task<SellerOutput> Execute(int SellerID);

    }
}

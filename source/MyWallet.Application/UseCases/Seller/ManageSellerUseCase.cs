using System;
using System.Collections.Generic;
using System.Text;
using RePro.Application.Repositories;
using RePro.Domain.Sellers;

using System.Threading.Tasks;

namespace RePro.Application.UseCases.Seller
{
    public class ManageSellerUseCase: IManageSellerUseCase
    {
        private readonly ISellerRepository _sellerRepository;
        public ManageSellerUseCase(ISellerRepository sellerRepository)
        {
            _sellerRepository = sellerRepository;
        }

    
        public async Task<SellerOutput> Execute(int sellerID)
        {
            RePro.Domain.Sellers.Seller seller = await _sellerRepository.Get(sellerID);
            if (seller == null)
                throw new SellerNotFoundException($"The seller {sellerID} does not exists or is not processed yet.");

            return new SellerOutput(seller);

        }
    }
}

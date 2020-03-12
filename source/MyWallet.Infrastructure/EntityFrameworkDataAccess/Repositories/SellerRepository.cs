using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using RePro.Application.Repositories;
using RePro.Domain.Sellers;
using Microsoft.EntityFrameworkCore;
namespace RePro.Infrastructure.EntityFrameworkDataAccess.Repositories
{
    public class SellerRepository : ISellerRepository
    {
        private readonly ReProDBContext _context;
        public SellerRepository(ReProDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task Add(Seller seller)
        {
            Entities.Seller sellerEntity = new Entities.Seller()
            {
                AddressPremises = seller.AddressPremises,
                AdressLine1 = seller.AdressLine1,
                AddressLine2 = seller.AddressLine2,
                City = seller.City,
                EmailID = seller.EmailID,
                MobileNo = seller.MobileNo,
                PAN = seller.PAN,
                PinCode = seller.PinCode,
                SellerName = seller.SellerName,
                StateID = seller.StateID
            };
            await _context.Sellers.AddAsync(sellerEntity);
            await _context.SaveChangesAsync();
        }

        public async Task<Seller> Get(int sellerId)
        {
            Entities.Seller seller = await _context.Sellers.FindAsync(sellerId);
            Seller domainSeller = new Seller()
            {
                SellerID = seller.SellerID,
                AddressPremises = seller.AddressPremises,
                AdressLine1 = seller.AdressLine1,
                AddressLine2 = seller.AddressLine2,
                City = seller.City,
                EmailID = seller.EmailID,
                MobileNo = seller.MobileNo,
                PAN = seller.PAN,
                PinCode = seller.PinCode,
                SellerName = seller.SellerName,
                StateID = seller.StateID
            };
            return domainSeller;
        }

        public Task Update(Seller seller)
        {
            throw new NotImplementedException();
        }
    }
}

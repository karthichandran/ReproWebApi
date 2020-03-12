using System;
using System.Collections.Generic;
using System.Linq;
using RePro.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace RePro.WebApi.UseCases.Seller
{
    public class Presenter
    {
        public IActionResult ViewModel { get; private set; }

        public void Populate(SellerOutput output)
        {
            if (output == null)
            {
                ViewModel = new NoContentResult();
                return; 
            }

            SellerModel model = new SellerModel() { 
                AddressPremises = output.AddressPremises,
                AdressLine1 = output.AdressLine1,
                AddressLine2 = output.AddressLine2,
                City = output.City,
                EmailID = output.EmailID,
                MobileNo = output.MobileNo,
                PAN = output.PAN,
                PinCode = output.PinCode,
                SellerID = output.SellerID,
                SellerName = output.SellerName,
                StateID = output.StateID
            };

            ViewModel = new ObjectResult(model);
        }
    }
}

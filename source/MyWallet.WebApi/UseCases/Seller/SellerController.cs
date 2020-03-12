using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RePro.Application.UseCases.Seller;

namespace RePro.WebApi.UseCases.Seller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : Controller
    {
        private readonly IManageSellerUseCase _manageSellerUseCase;
        private readonly Presenter _presenter;

        public SellerController(
            IManageSellerUseCase manageSellerUseCase,
            Presenter presenter )
        {

            _manageSellerUseCase = manageSellerUseCase;
            _presenter = presenter;
        }

        /// <summary>
        /// Get a Customer details 
        /// </summary>
        [HttpGet("{sellerId}", Name = "GetSeller")]
        public async Task<IActionResult> GetSeller(int sellerId)
        {
            RePro.Application.UseCases.SellerOutput output = await _manageSellerUseCase.Execute(sellerId);
            _presenter.Populate(output);
            return _presenter.ViewModel;
        }
    }
}
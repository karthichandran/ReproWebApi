using System;
using System.Collections.Generic;
using System.Text;

namespace RePro.Application.UseCases.Seller
{
     internal sealed class SellerNotFoundException : ApplicationException
    {
        internal SellerNotFoundException(string message) : base(message) { }
    }
}

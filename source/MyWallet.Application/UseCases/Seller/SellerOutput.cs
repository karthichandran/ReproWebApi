using System;
using System.Collections.Generic;
using System.Text;
using RePro.Domain.Sellers;

namespace RePro.Application.UseCases
{
    public sealed class SellerOutput
    {

		public int SellerID { get;  }
		public string SellerName { get;  }
		public string AddressPremises { get;  }
		public string AdressLine1 { get;  }
		public string AddressLine2 { get;  }
		public string City { get;  }
		public string PinCode { get;  }
		public string EmailID { get;  }
		public string PAN { get;  }
		public string MobileNo { get;  }
		public int StateID { get;  }

		public SellerOutput(RePro.Domain.Sellers.Seller seller) 
		{
			SellerID = seller.SellerID;
			AddressPremises = seller.AddressPremises;
			AdressLine1 = seller.AdressLine1;
			AddressLine2 = seller.AddressLine2;
			City = seller.City;
			EmailID = seller.EmailID;
			MobileNo = seller.MobileNo;
			PAN = seller.PAN;
			PinCode = seller.PinCode;
			SellerName = seller.SellerName;
			StateID = seller.StateID;
		}
    }
}

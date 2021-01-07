using System;
using System.Collections.Generic;
using System.Text;

namespace POSSimulator
{
    public sealed class PurchaseRequest : POSRequestBase
    {
		public PurchaseRequest() : base()
		{

		}
		public override string RequestType { get { return POSConstants.MessageType_Purchase;	}	}

		public decimal Amount { get; set; }

		public decimal CashAmount { get; set; }

		public string Id { get; set; }

		public void Validate()
		{

		}

	}
}
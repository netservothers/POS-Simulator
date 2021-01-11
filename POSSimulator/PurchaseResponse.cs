using System;
using System.Collections.Generic;
using System.Text;

namespace POSSimulator
{

    public sealed class PurchaseResponse : POSResponseBase
	{

		public PurchaseResponse(IList<string> fieldValues) : base(fieldValues) { }

		public override string MessageType => POSConstants.MessageType_Purchase;


    }
}
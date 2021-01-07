using System;
using System.Collections.Generic;
using System.Text;

namespace POSSimulator
{

    public sealed class PurchaseResponse : POSResponseBase
	{

		public PurchaseResponse(IList<string> fieldValues) : base(fieldValues) { }

		public override string MessageType { get { return POSConstants.MessageType_Purchase; } }
		
	}
}
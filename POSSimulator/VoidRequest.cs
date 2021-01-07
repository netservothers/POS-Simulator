using System;
using System.Collections.Generic;
using System.Text;

namespace POSSimulator
{
    public sealed class VoidRequest : POSRequestBase
	{
		public VoidRequest() : base()
		{

		}
 
		public override string RequestType
		{
			get { return POSConstants.MessageType_Refund; }
		}

		public decimal Amount { get; set; }

		public string Id { get; set; }

		public void Validate()
		{

		}
	}
}
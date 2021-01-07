using System;
using System.Collections.Generic;
using System.Text;

namespace POSSimulator
{
    public sealed class VoidResponse : POSResponseBase
	{
		public VoidResponse(IList<string> fieldValues) : base(fieldValues) { }

		public override string MessageType { get { return POSConstants.MessageType_Void; } }
	}
}
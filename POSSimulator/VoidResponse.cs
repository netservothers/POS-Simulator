using System;
using System.Collections.Generic;
using System.Text;

namespace POSSimulator
{
    public sealed class VoidResponse : POSResponseBase
	{

		/// <summary>
		/// Constructs a new message instance from the list of pre-decoded string values received from the pinpad.
		/// </summary>
		/// <param name="fieldValues">The list of values returned from the pinpad in the order specified by the protocol and message type.</param>
		/// <see cref="PollRequest"/>
		public VoidResponse(IList<string> fieldValues) : base(fieldValues) { }

		/// <summary>
		/// Returns "REF".
		/// </summary>
		public override string MessageType { get { return POSConstants.MessageType_Refund; } }
		
	}
}
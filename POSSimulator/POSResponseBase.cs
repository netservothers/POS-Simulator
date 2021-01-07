using System;
using System.Collections.Generic;
using System.Text;

namespace POSSimulator
{
	public abstract class POSResponseBase
	{
		private readonly IList<string> _Fields;

		protected POSResponseBase(IList<string> fieldValues)
		{
			_Fields = fieldValues;
		}

	    public abstract string MessageType { get; }

		protected IList<string> Fields { get { return _Fields; } }

		protected string FieldValueOrNull(int fieldIndex)
		{
			if (_Fields.Count > fieldIndex) return _Fields[fieldIndex];

			return null;
		}
	}
}

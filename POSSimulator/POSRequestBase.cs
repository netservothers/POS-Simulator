using System;
using System.Collections.Generic;
using System.Text;

namespace POSSimulator
{
	public abstract class POSRequestBase
	{
		protected POSRequestBase()
		{

		}
		public abstract string RequestType
		{
			get;
		}

        public abstract string MandatoryField
        {
            get;
        }

        public abstract string OptionalField
        {
            get;
        }

    }
}
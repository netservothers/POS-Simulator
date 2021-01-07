using System;
using System.Collections.Generic;
using System.Text;

namespace POSSimulator
{
    public static class ResponseCodes
	{
		/// <summary>
		/// The request was processsed successfully.
		/// </summary>
		public const string Approved = "00";

		/// <summary>
		/// The request was declined by the device or payment gateway.
		/// </summary>
		public const string Declined = "ND";

        /// <summary>
		/// Terminal cannot determine where this transaction should be sent to
		/// </summary>
		public const string DestinationError = "ED";

        /// <summary>
        /// The Terminal does not receive a response from the host in time.
        /// </summary>
        public const string TimeoutError = "TO";

        /// <summary>
        /// The Terminal will send this response code if it does not know how to process the transaction.
        /// </summary>
        public const string TransactioNotAvailable = "NA";

        /// <summary>
        /// The Terminal will check if the invoice number send from ECR is duplicate, and request will reject and response with DI.
        /// </summary>
        public const string DuplicateInvoiceNumber = "DI"; 
        /// <summary>
        /// The request is invalid.
        /// </summary>
        public const string InvalidRequest = "02";

		/// <summary>
		/// The amount associated with the request is invalid.
		/// </summary>
		public const string InvalidAmount = "03";

		/// <summary>
		/// The transaction was cancelled, either by the API, the user at the pin pad, or a timeout.
		/// </summary>
		public const string TransactionCancelled = "XC";

        /// <summary>
		/// User Cancel, e.g. User Press CANCEL key when enter PIN
		/// </summary>
		public const string UserCancel = "UC";

        /// <summary>
        /// User Cancel or VTI Time out
        /// </summary
        public const string VTITimeOut = "CN";
	}
}
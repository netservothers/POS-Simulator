using System;
using System.Linq;
using System.Text;
using POS_KIOSK_Payment_Plugin;

namespace POSSimulator
{
    public class POSSimulator
    {
        #region Variable Declaration 
        PurchaseRequest pOSPurchaseRequest = new PurchaseRequest();
        VoidRequest voidRequest = new VoidRequest();
        #endregion

        public POSSimulator()
        {
            
        }

        #region Public Methods 

        public string ProcessReadRequest(string input)
        {
            string RequestMessageInString = HextoString(input).ToString();

            if (RequestMessageInString.Substring(15, 2).ToString() == pOSPurchaseRequest.RequestType)
            {
                return BuildHexMessage(pOSPurchaseRequest.Validate(RequestMessageInString).ToString());
                
            }
            else if (RequestMessageInString.Substring(15, 2).ToString() == voidRequest.RequestType)
            {
                return BuildHexMessage(voidRequest.Validate(RequestMessageInString).ToString());

            }
            return string.Empty;
        }

        #endregion

        #region Private Methods
        private static string HextoString(string hexString)
        {

            var sb = new StringBuilder();
            for (var i = 0; i < hexString.Length; i += 2)
            {
                var hexChar = hexString.Substring(i, 2);
                sb.Append((char)Convert.ToByte(hexChar, 16));
            }
            return sb.ToString();
        }

        public string BuildHexMessage(string inputData)
        {
            try
            {
               return Byte.Parse(inputData).ToString();
            }
            catch
            {
                throw;
            }

        }

        #endregion
    }
}

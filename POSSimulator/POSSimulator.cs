using System;
using System.Linq;
using System.Text;
using POS_KIOSK_Payment_Plugin;

namespace POSSimulator
{
    public class POSSimulator
    {
        #region Variable Declaration 

        //private const string hexaDecimalFormat = "X2";

        //private const string POSMessageSTX = "02";

        //private const string POSMessageETX = "03";

        //private const string POSMessageFS = "1C";

        #endregion

        public POSSimulator()
        {
            
        }

        #region Public Methods 

        public string ProcessReadRequest(string input)
        {
            byte[] inputString = HexStringToBytes(input);

            //string readData = Encoding.Default.GetString(inputString);

            //string readASCIIData = Encoding.ASCII.GetString(inputString);

            //string readUnicodeData = Encoding.Unicode.GetString(inputString);

            //string readUTF32Data = Encoding.UTF32.GetString(inputString);

            //string readUTF72Data = Encoding.UTF7.GetString(inputString);

            //string readUTF8Data = Encoding.UTF8.GetString(inputString);

            //string readBigEndianUnicodeData = Encoding.BigEndianUnicode.GetString(inputString);

            return HextoString(input);
        }

        #endregion

        #region Private Methods

        private static byte[] HexStringToBytes(string hexString)
        {
            if (hexString == null)
                throw new ArgumentNullException("hexString");
            if (hexString.Length % 2 != 0)
                throw new ArgumentException("hexString must have an even length", "hexString");
            var bytes = new byte[hexString.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                string currentHex = hexString.Substring(i * 2, 2);
                bytes[i] = Convert.ToByte(currentHex, 16);
            }
            return bytes;
        }

        private static string HextoString(string hexString)
        {
            string stringValue = "";

            var sb = new StringBuilder();
            for (var i = 0; i < hexString.Length; i += 2)
            {
                var hexChar = hexString.Substring(i, 2);
                sb.Append((char)Convert.ToByte(hexChar, 16));
            }
            return sb.ToString();


            for (int i = 0; i < hexString.Length / 2; i++)
            {
                string hexChar = hexString.Substring(i * 2, 2);
                int hexValue = Convert.ToInt32(hexChar, 16);
                stringValue += Char.ConvertFromUtf32(hexValue);
            }
            return stringValue;
        }

        #endregion
    }
}

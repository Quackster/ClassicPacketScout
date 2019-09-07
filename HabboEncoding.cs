using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicPacketScout
{
    public static class WireEncoding
    {
        #region Fields
        public static byte NEGATIVE = 72; // 'H'
        public static byte POSITIVE = 73; // 'I'
        public static int MAX_INTEGER_BYTE_AMOUNT = 6;
        #endregion

        #region Methods
        public static string EncodeInt32(Int32 i)
        {
            byte[] wf = new byte[WireEncoding.MAX_INTEGER_BYTE_AMOUNT];
            int pos = 0;
            int numBytes = 1;
            int startPos = pos;
            int negativeMask = i >= 0 ? 0 : 4;
            i = Math.Abs(i);
            wf[pos++] = (byte)(64 + (i & 3));
            for (i >>= 2; i != 0; i >>= WireEncoding.MAX_INTEGER_BYTE_AMOUNT)
            {
                numBytes++;
                wf[pos++] = (byte)(64 + (i & 0x3f));
            }
            wf[startPos] = (byte)(wf[startPos] | numBytes << 3 | negativeMask);

            // Skip the null bytes in the result
            byte[] bzData = new byte[numBytes];
            for (int x = 0; x < numBytes; x++)
            {
                bzData[x] = wf[x];
            }

            return Encoding.Default.GetString(bzData);
        }
        public static Int32 DecodeInt32(string data, out Int32 totalBytes)
        {
            byte[] bzData = Encoding.Default.GetBytes(data);

            int pos = 0;
            int v = 0;
            bool negative = (bzData[pos] & 4) == 4;
            totalBytes = bzData[pos] >> 3 & 7;
            v = bzData[pos] & 3;
            pos++;
            int shiftAmount = 2;
            for (int b = 1; b < totalBytes; b++)
            {
                v |= (bzData[pos] & 0x3f) << shiftAmount;
                shiftAmount = 2 + 6 * b;
                pos++;
            }

            if (negative == true)
                v *= -1;

            return v;
        }
        #endregion
    }

    /// <summary>
    /// Provides methods for encoding and decoding integers to byte arrays. This class is static.
    /// </summary>
    public class Base64Encoding
    {
        #region Fields
        public static byte NEGATIVE = 64; // '@'
        public static byte POSITIVE = 65; // 'A'
        #endregion

        #region Methods
        /// <summary>
        /// Encodes a 32 bit integer to a Base64 byte array of a given length.
        /// </summary>
        /// <param name="i">The integer to encode.</param>
        /// <param name="numBytes">The length of the byte array.</param>
        /// <returns>A byte array holding the encoded integer.</returns>
        public static string EncodeInt32(Int32 i, int numBytes)
        {
            byte[] bzRes = new byte[numBytes];
            for (int j = 1; j <= numBytes; j++)
            {
                int k = ((numBytes - j) * 6);
                bzRes[j - 1] = (byte)(0x40 + ((i >> k) & 0x3f));
            }

            return Encoding.Default.GetString(bzRes);
        }

        /// <summary>
        /// Base64 decodes a byte array to a 32 bit integer.
        /// </summary>
        /// <param name="bzData">The input byte array to decode.</param>
        /// <returns>The decoded 32 bit integer.</returns>
        public static Int32 DecodeInt32(string data)
        {
            byte[] bzData = Encoding.Default.GetBytes(data);

            int i = 0;
            int j = 0;
            for (int k = bzData.Length - 1; k >= 0; k--)
            {
                int x = bzData[k] - 0x40;
                if (j > 0)
                    x *= (int)Math.Pow(64.0, (double)j);

                i += x;
                j++;
            }

            return i;
        }
        #endregion
    }
}

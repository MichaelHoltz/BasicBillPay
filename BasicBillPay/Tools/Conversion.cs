using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicBillPay.Tools
{
    internal static class Conversion
    {
        internal static void FloatToCurrencyString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("c").
            cevent.Value = ((float)cevent.Value).ToString("c");
        }

        internal static void CurrencyStringToFloat(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to decimal type only. 
            if (cevent.DesiredType != typeof(float)) return;

            // Converts the string back to decimal using the static Parse method.
            cevent.Value = float.Parse(cevent.Value.ToString(), NumberStyles.Currency, null);
        }
        /// <summary>
        /// Returns singularName's or persons' with NO Trailing Spaces
        /// </summary>
        /// <param name="singlularName">Insure the name is trimmed before sending here.</param>
        /// <returns></returns>
        internal static String Pluralize(String singlularName)
        {
            //Get Proper Ending
            String ending = "'s";
            if (singlularName.EndsWith("s"))
            {
                ending = "'";
            }
            return singlularName + ending;
        }
    }
}

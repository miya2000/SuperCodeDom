using System;
using System.Text.RegularExpressions;
using System.Security;

namespace SuperCodeDom
{
    /// <summary>
    /// Utility for SuperCodeDom.
    /// </summary>
    public class Utility
    {
        //Public Method
        #region EscIdentifier
        /// <summary>
        /// escape for identifier.
        /// </summary>
        /// <param name="str">target string.</param>
        /// <returns>escaped string.</returns>
        public static string EscIdentifier(string str)
        {
            string result = str;
            // remove CRLF.
            result = Regex.Replace(result, @"\r?\n", "");
            // convert space, period to under score.
            result = Regex.Replace(result, @"(\s)+", "_");
            result = result.Replace('.', '_');
            // № to No.
            result = result.Replace("№", "No");
            // remove signs excludes under score.
            result = Regex.Replace(result, @"[\W-[_]]", "");
            // add under score at top of string if the string starts with number.
            result = Regex.Replace(result, @"^([0-9])", @"_$1");
            return result;
        }
        #endregion
        #region EscXml
        /// <summary>
        /// escape for xml.
        /// </summary>
        /// <param name="str">>target string.</param>
        /// <returns>escaped string.</returns>
        public static string EscXml(string str)
        {
            string result = str;
            // remove CRLF.
            result = Regex.Replace(result, @"\r?\n", "");
            // escape tags.
            result = SecurityElement.Escape(result);
            return result;
        }
        #endregion
    }
}

using System;

namespace Nitrogen.Foundation.Util
{
    /// <summary>
    /// ValidateExtension。
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        /// CheckNuLL。
        /// </summary>
        /// <param name="obj">obj。</param>
        /// <param name="parameteName">parameteName。</param>
        public static void CheckNull(this object obj, string parameteName)
        {
            if (obj == null)
                throw new ArgumentNullException(parameteName);
        }

        /// <summary>
        /// IsEmpty。
        /// </summary>
        /// <param name="value">value。</param>
        /// <returns>bool。</returns>
        public static bool IsEmpty(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }


        public static bool IsEmpty(this Guid value)
        {
            return value == Guid.Empty;
        }

        public static bool IsEmpty(this object value)
        {
            return value == null || string.IsNullOrEmpty(value.ToString());
        }

    }
}

using System;
using System.Linq;

namespace Palindromic_prime
{
    /// <summary>
    /// Extensions for string class
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Gets n characters of string from the left
        /// </summary>
        /// <param name="value"></param>
        /// <param name="maxLenght"></param>
        /// <returns>string</returns>
        public static string Left(this string value, int maxLenght)
        {
            if (string.IsNullOrWhiteSpace(value)) return value;
            maxLenght = Math.Abs(maxLenght);
            return value.Length <= maxLenght ? value : value.Substring(0, maxLenght);
        }

        /// <summary>
        /// Gets n characters of string from the right
        /// </summary>
        /// <param name="value"></param>
        /// <param name="maxLenght"></param>
        /// <returns>string</returns>
        public static string Right(this string value, int maxLenght)
        {
            if (string.IsNullOrWhiteSpace(value)) return value;
            maxLenght = Math.Abs(maxLenght);
            return value.Length <= maxLenght ? value : value.Substring(value.Length - maxLenght, maxLenght);
        }

        /// <summary>
        /// Gets a string reversed
        /// </summary>
        /// <param name="input"></param>
        /// <returns>string</returns>
        public static string Reverse(this string input)
        {
            return string.Concat(Enumerable.Reverse(input));
        }
    }
}
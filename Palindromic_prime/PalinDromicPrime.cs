using System;
using System.Collections.Generic;

namespace Palindromic_prime
{
    /// <summary>
    /// Class Library to Calculation of Prime and PalinDromic
    /// </summary>
    public class PalinDromicPrime
    {
        #region Constructors
        #endregion

        #region Public Procedures

        /// <summary>
        /// Calculates the PalinDromic Primes within a range on the numberbase defined.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="basenumber"></param>
        /// <exception cref="IndexOutOfRangeException"></exception>
        /// <returns>List of strings</returns>
        public static List<string> PalinDromePrime(int start, int end, int basenumber)
        {
            try
            {
                var result = new List<string>();
                if(start >= end)
                {
                    throw new IndexOutOfRangeException("Start are larger then end");
                }

                for (var i = start; i <= end; i++)
                {
                    var isPrime = IsPrime(i);
                    var isPalinDromic = IsPalinDrome(i, basenumber);
                    if (isPrime.HasValue && isPalinDromic.HasValue)
                    {
                        if(isPrime.Value && isPalinDromic.Value)
                        { result.Add(Convert.ToString(i, basenumber));}
                    }
                }
                return result;
            }
            catch(Exception ex)
            {
                LogWriter.LogWrite(ex.Message);
                return new List<string>();
            }
        }

        /// <summary>
        /// Calculates if a number is a Prime.
        /// </summary>
        /// <param name="i"></param>
        /// <returns>boolean</returns>
        public static bool? IsPrime(int i)
        {
            try
            {
                if (i < 2) return false;
                var div = i / 2;
                for (var x = 2; x <= div; x++)
                    if (i % x == 0) return false;
                return true;
            }
            catch(Exception ex)
            {
                LogWriter.LogWrite(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Calculates if a number in the base is PalinDromic
        /// </summary>
        /// <param name="i"></param>
        /// <param name="basenumber"></param>
        /// <returns>boolean</returns>
        public static bool? IsPalinDrome(int i, int basenumber = 10)
        {
            try
            {
                if (i < basenumber) return true;
                var lengthOfNumber = (int) Math.Floor(Math.Log(i) / Math.Log(basenumber)) + 1;
                var number = Convert.ToString(i, basenumber);
                var leftside = number.Left(lengthOfNumber / 2);
                var rightside = number.Right(lengthOfNumber / 2).Reverse();
                return leftside.Equals(rightside);
            }
            catch (Exception ex)
            {
                LogWriter.LogWrite(ex.Message);
                return null;
            }
        }
        #endregion
    }
}
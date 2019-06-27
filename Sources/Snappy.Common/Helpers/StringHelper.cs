using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Snappy.Common.Helpers
{
    public static class StringHelper
    {
        public static bool IsAlphabeticalOrUnderscore(this string text)
        {
            var isAlphabetical = new Regex(@"[a-z_]+");

            var isValidated = isAlphabetical.IsMatch(text);
            return isValidated;
        }

        /// <summary>
        /// Checks if a string contains number, upper case, lower case and more than 7 character 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsValidPassword(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)
                || text.Length < 8)
            {
                return false;
            }

            var hasNumber = new Regex(@"[0-9]+", RegexOptions.Compiled);
            var hasLowerChar = new Regex(@"[a-z]+", RegexOptions.Compiled);
            var hasUpperChar = new Regex(@"[A-Z]+", RegexOptions.Compiled);

            var isValidated = hasNumber.IsMatch(text)
                              && hasUpperChar.IsMatch(text)
                              && hasLowerChar.IsMatch(text);
            return isValidated;
        }

        public static bool IsNotValidPassword(this string text)
        {
            return !IsValidPassword(text);
        }

        public static bool IsEmail(this string text)
        {
            try
            {
                var mailAddress = new MailAddress(text);
                return mailAddress.Address == text;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsNotEmail(this string text)
        {
            return !IsEmail(text);
        }

        public static bool IsEmpty(this string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }

        public static bool IsNotEmpty(this string text)
        {
            return !IsEmpty(text);
        }

        public static bool IsTrue(this string text)
        {
            if (text.IsNotEmpty()
                && (text.ToLowerInvariant() == "true"
                    || text == "1"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsFalse(this string text)
        {
            return !IsTrue(text);
        }

        public static bool IsUrl(this string text)
        {
            var result = Uri.TryCreate(text, UriKind.Absolute, out var uriResult)
                         && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            return result;
        }

        public static bool IsNotUrl(this string text)
        {
            return !IsUrl(text);
        }

        /// <summary>
        /// Checks if a string is cron expression 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsValidCronExpression(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }

            // todo:
            // var cronExpressionText = new Regex(@"", RegexOptions.Compiled);

            // var isValidated = cronExpressionText.IsMatch(text);
            var isValidated = true;

            return isValidated;
        }

        public static bool IsNotValidCronExpression(this string text)
        {
            return !IsValidCronExpression(text);
        }

        public static string TrimOrDefault(this string text)
        {
            return text == null ? string.Empty : text.Trim();
        }

        public static string CleanWhitespaces(this string text)
        {
            return Regex.Replace(text, @"\s+", "");
        }

        /// <summary>
        /// checks if .xls, .xlsx or .csv
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsBasicDataUploadExtension(this string text)
        {
            return text == ".csv"
                   || text == ".xls"
                   || text == ".xlsx";
        }

        public static bool IsNotBasicDataUploadExtension(this string text)
        {
            return !IsBasicDataUploadExtension(text);
        }
    }
}
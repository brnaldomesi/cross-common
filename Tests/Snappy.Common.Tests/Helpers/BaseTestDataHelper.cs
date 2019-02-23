using System;
using Snappy.Common.Helpers;

namespace Snappy.Common.Tests.Helpers
{
    public class BaseTestDataHelper
    {
        public const string EMPTY_STRING = "";
        public const string STRING = "string";
        public const string STRING_1 = "string_1";
        public const string STRING_2 = "string_2";
        public const string STRING_3 = "string_3";
        public const string STRING_4 = "string_4";
        public const string STRING_5 = "string_5";
        public const string STRING_6 = "string_6";
        public const string STRING_7 = "string_7";
        public const string STRING_8 = "string_8";
        public const string STRING_9 = "string_9";
        public const string STRING_10 = "string_10";

        public const int POSITIVE_NUMBER = 1;
        public const int POSITIVE_NUMBER_DIFFERENT = 2;
        public const int POSITIVE_NUMBER_OTHER = 3;

        public const int ZERO_NUMBER = 0;

        public const int NEGATIVE_NUMBER = -1;
        public const int NEGATIVE_NUMBER_DIFFERENT = -2;
        public const int NEGATIVE_NUMBER_OTHER = -3;

        public const double NEGATIVE_DOUBLE_NUMBER = -1.04;
        public const double NEGATIVE_DOUBLE_NUMBER_DIFFERENT = -2.04;
        public const double NEGATIVE_DOUBLE_NUMBER_OTHER = -3.04;

        public const double POSITIVE_DOUBLE_NUMBER = 1.04;
        public const double POSITIVE_DOUBLE_NUMBER_DIFFERENT = 2.04;
        public const double POSITIVE_DOUBLE_NUMBER_OTHER = 3.04;

        public const string DATE_FORMAT_PATTERN_1 = "2019-01-16";
        public const string DATE_FORMAT_PATTERN_2 = "2019-01-17";
        public const string DATE_FORMAT_PATTERN_3 = "2019-01-18";

        public const string PASSWORD = "Test+-2018*";
        public const string PASSWORD_1 = "Test+-2018*+";
        public const string PASSWORD_2 = "Test+-2018**";

        public const string PASSWORD_INVALID = "invalid-password";

        public const string UID = "ee4c5b8a-3498-4a7d-a9c8-74e86075853c";
        public const string UID_1 = "b64c5b8a-3498-4a7d-a9c8-74e86075853c";
        public const string UID_2 = "1f6f9edc-4da4-444f-82dd-e089c9ebd68d";

        public const string EMAIL = "test@test.com";
        public const string EMAIL_1 = "test_1@test_1.com";
        public const string EMAIL_2 = "test_2@test_2.com";

        public const string EMAIL_INVALID = "invalid-email";

        public const long LONG = 2147483649L;
        public const long LONG_1 = 7447454649L;
        public const long LONG_2 = 9647483649L;

        public const bool BOOL_TRUE = true;
        public const bool BOOL_FALSE = false;

        public const string URL_HTTP = "http://turkiye.gov.tr";
        public const string URL_HTTP_WWW = "http://www.turkiye.gov.tr";
        public const string URL_HTTP_SHORT = "http://aka.ms";
        public const string URL_HTTPS = "https://turkiye.gov.tr";
        public const string URL_HTTPS_WWW = "https://www.turkiye.gov.tr";
        public const string URL_HTTPS_SHORT = "https://aka.ms";

        public const string ISO_CODE_2 = "TR";
        public const string ISO_CODE_3 = "TUR";

        public static Guid GetNewGuid()
        {
            return Guid.NewGuid();
        }

        public static Guid GetEmptyGuid()
        {
            return Guid.Empty;
        }

        public static Guid GetStringAsGuid(string uid)
        {
            if (uid.IsNotUid())
            {
                return Guid.Empty;
            }
            return new Guid(uid);
        }

        public static string GetUidAsString(Guid uid)
        {
            return uid.ToString("N").ToLowerInvariant();
        }
    }
}

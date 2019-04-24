using System;
using Microsoft.AspNetCore.Http;

using Moq;

using Snappy.Common.Helpers;

namespace Snappy.Common.Tests.Helpers
{
    public class BaseTestDataHelper
    {
        public static string BASE_64_STRING = "bXk=";
        public static string BASE_64_STRING_1 = "bXkx";
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

        public const int POSITIVE_INT_NUMBER_1 = 1;
        public const int POSITIVE_INT_NUMBER_2 = 2;
        public const int POSITIVE_INT_NUMBER_3 = 3;
        public const int POSITIVE_INT_NUMBER_4 = 4;
        public const int POSITIVE_INT_NUMBER_5 = 5;
        public const int POSITIVE_INT_NUMBER_6 = 6;
        public const int POSITIVE_INT_NUMBER_7 = 7;
        public const int POSITIVE_INT_NUMBER_8 = 8;
        public const int POSITIVE_INT_NUMBER_9 = 9;
        public const int POSITIVE_INT_NUMBER_10 = 10;

        public const int ZERO_NUMBER = 0;

        public const int NEGATIVE_INT_NUMBER_1 = -1;
        public const int NEGATIVE_INT_NUMBER_2 = -2;
        public const int NEGATIVE_INT_NUMBER_3 = -3;
        public const int NEGATIVE_INT_NUMBER_4 = -4;
        public const int NEGATIVE_INT_NUMBER_5 = -5;
        public const int NEGATIVE_INT_NUMBER_6 = -6;
        public const int NEGATIVE_INT_NUMBER_7 = -7;
        public const int NEGATIVE_INT_NUMBER_8 = -8;
        public const int NEGATIVE_INT_NUMBER_9 = -9;
        public const int NEGATIVE_INT_NUMBER_10 = -10;

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
        public const long LONG_3 = 9645483649L;
        public const long LONG_4 = 8647483649L;
        public const long LONG_5 = 7647483649L;
        public const long LONG_6 = 6647483649L;
        public const long LONG_7 = 1647483649L;
        public const long LONG_8 = 2647483649L;
        public const long LONG_9 = 4647483649L;
        public const long LONG_10 = 7645483649L;

        public const bool BOOL_TRUE = true;
        public const bool BOOL_FALSE = false;

        public const string URL_HTTP = "http://turkiye.gov.tr";
        public const string URL_HTTP_WWW = "http://www.turkiye.gov.tr";
        public const string URL_HTTP_SHORT = "http://aka.ms";
        public const string URL_HTTPS = "https://turkiye.gov.tr";
        public const string URL_HTTPS_WWW = "https://www.turkiye.gov.tr";
        public const string URL_HTTPS_SHORT = "https://aka.ms";

        public const string IP = "87.204.85.116";

        public const string ISO_CODE_2 = "TR";
        public const string ISO_CODE_3 = "TUR";

        public const string CASE_1 = "case_1";
        public const string CASE_2 = "case_2";
        public const string CASE_3 = "case_3";
        public const string CASE_4 = "case_4";
        public const string CASE_5 = "case_5";
        public const string CASE_6 = "case_6";
        public const string CASE_7 = "case_7";
        public const string CASE_8 = "case_8";
        public const string CASE_9 = "case_9";
        public const string CASE_10 = "case_10";
        public const string CASE_11 = "case_11";
        public const string CASE_12 = "case_12";
        public const string CASE_13 = "case_13";
        public const string CASE_14 = "case_14";
        public const string CASE_15 = "case_15";
        public const string CASE_16 = "case_16";
        public const string CASE_17 = "case_17";
        public const string CASE_18 = "case_18";
        public const string CASE_19 = "case_19";
        public const string CASE_20 = "case_20";

        public static Guid GetParkNetOrganizationUid()
        {
            return new Guid("a497048f-34a6-4730-8199-ac81617c3929");
        }

        public static long GetParkNetOrganizationId()
        {
            return 7647483649L;
        }

        public static Guid GetBlueSoftOrganizationUid()
        {
            return new Guid("87167bfe-c2b3-4e6b-9126-341ff4bb4f66");
        }

        public static Guid GetNewGuid()
        {
            return new Guid("3A2F7BA0-0D4C-4231-B9DF-A15460B60BD2");
        }

        public static Guid GetNewGuid_1()
        {
            return new Guid("5bb6cdd7-b5d1-4cf0-98c9-9bc68fa940c3");
        }

        public static Guid GetNewGuid_2()
        {
            return new Guid("5f329bf2-7d4f-490a-a014-c15570ebbe06");
        }

        public static Guid GetNewGuid_3()
        {
            return new Guid("6886356d-a0f6-4e0f-829c-70a61df33ca3");
        }

        public static Guid GetNewGuid_4()
        {
            return new Guid("92b97a02-b151-4ec0-8e4a-7a07ff318615");
        }

        public static Guid GetNewGuid_5()
        {
            return new Guid("706ecd9d-1547-4643-bb8f-9aa7b92e9e16");
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
            return uid.ToString("D").ToLowerInvariant();
        }

        public static IFormFile GetMockFile()
        {
            var mockFile = new Mock<IFormFile>();
            mockFile.Setup(x => x.Length).Returns(100);

            return mockFile.Object;
        }
    }
}

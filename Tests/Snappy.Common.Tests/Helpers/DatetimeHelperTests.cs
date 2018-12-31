using NodaTime;
using NodaTime.Testing;
using NodaTime.Text;
using NUnit.Framework;

using Snappy.Common.Helpers;

namespace Snappy.Common.Tests.Helpers
{
    [TestFixture]
    public class DatetimeHelperTests
    {
        public const string DATE_FORMAT_PATTERN = "yyyy-MM-dd";
        public const string TIME_FORMAT_PATTERN = "yyyy-MM-dd-HH-mm";

        [Test]
        public void DatetimeHelper_GetNow()
        {
            // arrange
            var helper = GetDatetimeHelper();

            // act
            var result = helper.GetNow();

            // assert
            Assert.AreEqual(result, GetFakeNow());
        }

        [Test]
        public void DatetimeHelper_GetString()
        {
            // arrange
            var helper = GetDatetimeHelper();

            // act
            var result = helper.GetString(helper.GetNow(), DATE_FORMAT_PATTERN);

            // assert
            Assert.AreEqual(result, InstantPattern.CreateWithInvariantCulture(DATE_FORMAT_PATTERN).Format(GetFakeNow()));
        }

        [Test]
        public void DatetimeHelper_GetNowAsString()
        {
            // arrange
            var helper = GetDatetimeHelper();

            // act
            var result = helper.GetNowAsString(TIME_FORMAT_PATTERN);

            // assert
            Assert.AreEqual(result, InstantPattern.CreateWithInvariantCulture(TIME_FORMAT_PATTERN).Format(GetFakeNow()));
        }

        [Test]
        public void DatetimeHelper_GetTodayAsString()
        {
            // arrange
            var helper = GetDatetimeHelper();

            // act
            var result = helper.GetTodayAsString(DATE_FORMAT_PATTERN);

            // assert
            Assert.AreEqual(result, InstantPattern.CreateWithInvariantCulture(DATE_FORMAT_PATTERN).Format(GetFakeNow()));
        }

        private Instant GetFakeNow()
        {
            return Instant.FromUtc(2018, 12, 31, 10, 20, 30);
        }

        private DatetimeHelper GetDatetimeHelper()
        {
            var clock = new FakeClock(GetFakeNow());
            var helper = new DatetimeHelper(clock);
            return helper;
        }
    }
}
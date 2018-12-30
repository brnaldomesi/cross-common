using NodaTime;
using NodaTime.Testing;
using NUnit.Framework;

using Snappy.Common.Helpers;

namespace Snappy.Common.Tests.Helpers
{
    public class DatetimeHelperTests
    {
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
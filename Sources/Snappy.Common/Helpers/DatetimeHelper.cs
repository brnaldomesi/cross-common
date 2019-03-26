using NodaTime;
using NodaTime.Text;

namespace Snappy.Common.Helpers
{
    public class DatetimeHelper : IDatetimeHelper
    {
        private readonly IClock _clock;

        public const string DATE_FORMAT_PATTERN = "yyyy-MM-dd";
        public const string TIME_FORMAT_PATTERN = "yyyy-MM-dd-HH-mm";

        public DatetimeHelper(IClock clock = null)
        {
            _clock = clock ?? SystemClock.Instance;
        }

        public Instant GetNow()
        {
            return _clock.GetCurrentInstant();
        }

        public string GetString(Instant instant, string format)
        {
            return InstantPattern.CreateWithInvariantCulture(format).Format(instant);
        }

        public string GetNowAsString(string format = null)
        {
            return InstantPattern.CreateWithInvariantCulture(format ?? TIME_FORMAT_PATTERN).Format(GetNow());
        }

        public string GetTodayAsString(string format = null)
        {
            return InstantPattern.CreateWithInvariantCulture(format ?? DATE_FORMAT_PATTERN).Format(GetNow());
        }

        public Instant GetInstantFromString(string date, string format = null)
        {
            return InstantPattern.CreateWithInvariantCulture(format ?? DATE_FORMAT_PATTERN).Parse(date).Value;
        }
    }
}
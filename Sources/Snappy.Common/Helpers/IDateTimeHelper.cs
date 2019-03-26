using NodaTime;

namespace Snappy.Common.Helpers
{
    public interface IDatetimeHelper
    {
        Instant GetNow();
        string GetString(Instant instant, string format);
        string GetNowAsString(string format = null);
        string GetTodayAsString(string format = null);
        Instant GetInstantFromString(string date, string format = null);
    }
}
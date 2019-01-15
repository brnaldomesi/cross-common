namespace Snappy.Common.Models.Shared
{
    public class ResilienceInfo
    {
        public int TimeOutInSeconds { get; }
        
        public bool IsCancelOnError { get; }
        
        public bool IsReTryOnError { get; }
        public int ReTryAfterInSeconds { get; }
        public int ReTryCount { get; }
        
        public ResilienceInfo(int timeoutInSeconds = 30, 
                              bool isReTryOnError = false, int reTryCount = 0, int reTryAfterInSeconds = 0) 
        {
            TimeOutInSeconds = timeoutInSeconds;
            
            IsReTryOnError = isReTryOnError;
            ReTryAfterInSeconds = retryAfterInSeconds;
            ReTryCount = reTryCount;
            
            IsCancelOnError = !IsReTryOnError;
        }
    }
}

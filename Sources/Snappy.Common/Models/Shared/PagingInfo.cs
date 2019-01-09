namespace Snappy.Common.Models.Shared
{
    public class PagingInfo
    {
        public int Skip { get; set; }
        public int Take { get; set; }

        public int PageItemCount { get; set; }
        public long TotalItemCount { get; set; }

        public int CurrentPage { get; set; }
        public int PageCount { get; set; }

        public long LastId { get; set; }
        public long FirstId { get; set; }

        public bool IsHavingPrevious { get; set; }
        public bool IsHavingNext { get; set; }
    }
}
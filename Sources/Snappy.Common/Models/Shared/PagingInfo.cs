namespace Snappy.Common.Models.Shared
{
    public class PagingInfo
    {
        public const string NEXT_PREVIOUS = "next_previous";
        public const string PAGE_NUMBERS = "page_numbers";

        public int Skip { get; set; }
        public int Take { get; set; }

        public string LastUid { get; set; }
        public bool IsAscending { get; set; }
        
        public long TotalItemCount { get; set; }

        public int CurrentPage { get; set; }

        public bool IsHavingPrevious { get; set; }
        public bool IsHavingNext { get; set; }
        
        public string Type { get; set; }

        public PagingInfo()
        {
            LastUid = string.Empty;
            IsAscending = true;
            Take = 100;
        }
    }
}
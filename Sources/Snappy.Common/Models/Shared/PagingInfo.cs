using System;

namespace Snappy.Common.Models.Shared
{
    public class PagingInfo
    {
        public const string NEXT_PREVIOUS = "next_previous";
        public const string PAGE_NUMBERS = "page_numbers";
        public string Type { get; set; }

        public int Skip { get; set; }
        public int Take { get; set; }

        public Guid LastUid { get; set; }
        public bool IsAscending { get; set; }

        public long TotalItemCount { get; set; }

        public int CurrentPage
        {
            get
            {
                if (Skip < 1)
                {
                    return 1;
                }

                return (Skip / Take) + 1;
            }
        }

        public bool IsHavingPrevious
        {
            get { return Skip > 0; }
        }

        public bool IsHavingNext
        {
            get
            {
                return TotalItemCount - (Skip + Take) > 0;
            }
        }

        public PagingInfo()
        {
            IsAscending = true;
            Take = 100;
        }
    }
}
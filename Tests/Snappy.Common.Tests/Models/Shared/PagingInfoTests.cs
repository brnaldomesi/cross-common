using System;
using System.Collections;

using NUnit.Framework;
using Shouldly;

using Snappy.Common.Models.Shared;
using static Snappy.Common.Tests.Helpers.BaseTestDataHelper;

namespace Snappy.Common.Tests.Models.Shared
{
    [TestFixture]
    public class PagingInfoTests
    {
        [TestCase(2, 2)]
        [TestCase(0, 0)]
        [TestCase(-1, 0)]
        public void PagingInfo_Skip(int skip, int expected)
        {
            // arrange
            var pagingInfo = GetPagingInfo(skip, 0, POSITIVE_INT_NUMBER_100);

            // act
            var result = pagingInfo.Skip;

            // assert
            result.ShouldBe(expected);
        }

        [TestCase(101, 100)]
        [TestCase(100, 100)]
        [TestCase(6, 6)]
        [TestCase(0, 100)]
        [TestCase(-1, 100)]
        public void PagingInfo_Take(int take, int expected)
        {
            // arrange
            var pagingInfo = GetPagingInfo(0, take, POSITIVE_INT_NUMBER_100);

            // act
            var result = pagingInfo.Take;

            // assert
            result.ShouldBe(expected);
        }

        public static IEnumerable LastUidTestCases
        {
            get
            {
                yield return new TestCaseData(GetNewGuid(), GetNewGuid());
                yield return new TestCaseData(GetNewGuid_1(), GetNewGuid_1());
            }
        }

        [TestCaseSource(nameof(LastUidTestCases))]
        public void PagingInfo_LastUid(Guid LastUid, Guid expected)
        {
            // arrange
            var pagingInfo = GetPagingInfo(0, 0, 0, LastUid);

            // act
            var result = pagingInfo.LastUid;

            // assert
            result.ShouldBe(expected);
        }

        [TestCase(4, 10, (4 / 10) + 1)]
        [TestCase(-5, 10, 1)]
        public void PagingInfo_CurrentPage(int skip, int take, int expected)
        {
            // arrange
            var pagingInfo = GetPagingInfo(skip, take, POSITIVE_INT_NUMBER_100);

            // act
            var result = pagingInfo.CurrentPage;

            // assert
            result.ShouldBe(expected);
        }

        [TestCase(3, 8, 10, false)]
        [TestCase(4, 5, 16, true)]
        public void PagingInfo_IsHavingNext(int skip, int take, int totalItemCount, bool expected)
        {
            // arrange
            var pagingInfo = GetPagingInfo(skip, take, totalItemCount);

            // act
            var result = pagingInfo.IsHavingNext;

            // assert
            result.ShouldBe(expected);
        }

        private PagingInfo GetPagingInfo(int skip, int take, int totalItemCount, Guid lastUid = default(Guid))
        {
            if (lastUid == default(Guid))
            {
                lastUid = GetNewGuid();
            }

            var pagingInfo = new PagingInfo();
            pagingInfo.Skip = skip;
            pagingInfo.Take = take;
            pagingInfo.LastUid = lastUid;
            pagingInfo.TotalItemCount = totalItemCount;

            return pagingInfo;
        }
    }


}
using System;

using NUnit.Framework;
using Shouldly;

using Snappy.Common.Helpers;

namespace Snappy.Common.Tests.Helpers
{
    public class GuidHelperTests
    {
        [TestCase("f3feeac7332e4dadbdfbf14964470f43")]
        [TestCase("D9485A35-A270-4C30-BDF8-80D0CA86DD2C")]
        [TestCase("CA125BE1158C4F768EA1A93A391868BD")]
        [TestCase("97bb402f-3cd6-4882-a8ab-d745ef683825")]
        public void GuidHelper_IsUid(string text)
        {
            Assert.True(text.IsUid());
        }

        [TestCase("can")]
        public void GuidHelper_IsNotUid(string text)
        {
            Assert.True(text.IsNotUid());
        }

        [TestCase("5f970aca-f83f-4779-b78c-b7b081f5a9")]
        [TestCase("can")]
        public void GuidHelper_ValidateUid(string text)
        {
            Assert.Throws<ArgumentException>(text.ValidateUid);
        }

        [Test]
        public void GuidHelper_GetNewUid()
        {
            var result = GuidHelper.GetNewUid();
            Assert.IsNotNull(result);
            Assert.True(result.IsUid());
        }

        [Test]
        public void GuidHelper_IsEmptyGuid()
        {
            var item = Guid.Empty;
            item.IsEmptyGuid().ShouldBeTrue();

            var otherItem = Guid.NewGuid();
            otherItem.IsEmptyGuid().ShouldBeFalse();
        }

        [Test]
        public void GuidHelper_IsNotEmptyGuid()
        {
            var item = Guid.Empty;
            item.IsNotEmptyGuid().ShouldBeFalse();

            var otherItem = Guid.NewGuid();
            otherItem.IsNotEmptyGuid().ShouldBeTrue();
        }
    }
}
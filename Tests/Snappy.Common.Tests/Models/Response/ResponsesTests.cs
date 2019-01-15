﻿using NUnit.Framework;

using Snappy.Common.Models.Responses;

namespace Snappy.Common.Tests.Models.DataTransferObjects
{
    [TestFixture]
    public class ResponsesTests
    {
        [Test]
        public void BaseResponse_is_abstract()
        {
            Assert.True(typeof(BaseResponse).IsAbstract);
        }
    }
}
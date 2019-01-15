﻿using NUnit.Framework;

using Snappy.Common.Models.Requests;

namespace Snappy.Common.Tests.Models.DataTransferObjects
{
    [TestFixture]
    public class RequestsTests
    {
        [Test]
        public void BaseRequest_is_abstract()
        {
            Assert.True(typeof(BaseRequest).IsAbstract);
        }
    }
}
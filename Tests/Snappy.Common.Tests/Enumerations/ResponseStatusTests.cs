using NUnit.Framework;

using Snappy.Common.Enumerations;
using Snappy.Common.Enumerations.Base;

namespace Snappy.Common.Tests.Enumerations
{
    [TestFixture]
    public class ResponseStatusTests
    {
        [Test]
        public void ResponseStatus_Unknown()
        {
            var item = ResponseStatus.Unknown;

            Assert.AreEqual(0, item.Value);
            Assert.AreEqual("Unknown", item.DisplayName);
            Assert.AreEqual(string.Empty, item.Description);
        }

        [Test]
        public void ResponseStatus_Success()
        {
            var item = ResponseStatus.Success;

            Assert.AreEqual(1, item.Value);
            Assert.AreEqual("Success", item.DisplayName);
            Assert.AreEqual(string.Empty, item.Description);
        }

        [Test]
        public void ResponseStatus_Failed()
        {
            var item = ResponseStatus.Failed;

            Assert.AreEqual(2, item.Value);
            Assert.AreEqual("Failed", item.DisplayName);
            Assert.AreEqual(string.Empty, item.Description);
        }

        [Test]
        public void ResponseStatus_Invalid()
        {
            var item = ResponseStatus.Invalid;

            Assert.AreEqual(3, item.Value);
            Assert.AreEqual("Invalid", item.DisplayName);
            Assert.AreEqual(string.Empty, item.Description);
        }

        [Test]
        public void ResponseStatus_SuccessWithProblems()
        {
            var item = ResponseStatus.SuccessWithProblems;

            Assert.AreEqual(4, item.Value);
            Assert.AreEqual("SuccessWithProblems", item.DisplayName);
            Assert.AreEqual(string.Empty, item.Description);
        }

        [Test]
        public void ResponseStatus_Has_4_Items()
        {
            var items = Enumeration.GetAll<ResponseStatus>();

            Assert.AreEqual(4, items.Count);
            Assert.True(items.Contains(ResponseStatus.Unknown));
            Assert.True(items.Contains(ResponseStatus.Success));
            Assert.True(items.Contains(ResponseStatus.Failed));
            Assert.True(items.Contains(ResponseStatus.Invalid));
            Assert.True(items.Contains(ResponseStatus.SuccessWithProblems));
        }
    }
}
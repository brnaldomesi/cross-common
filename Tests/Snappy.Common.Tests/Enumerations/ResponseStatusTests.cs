using NUnit.Framework;

using Snappy.Common.Enumerations;

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
        public void ResponseStatus_Has_3_Items()
        {
            var items = Enumeration.GetAll<ResponseStatus>();

            Assert.AreEqual(3, items.Count);
            Assert.True(items.Contains(ResponseStatus.Unknown));
            Assert.True(items.Contains(ResponseStatus.Success));
            Assert.True(items.Contains(ResponseStatus.Failed));
        }
    }
}
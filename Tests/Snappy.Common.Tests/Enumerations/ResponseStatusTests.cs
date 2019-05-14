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
            Assert.AreEqual("not_informed_reason", item.Description);
        }

        [Test]
        public void ResponseStatus_Success()
        {
            var item = ResponseStatus.Success;

            Assert.AreEqual(1, item.Value);
            Assert.AreEqual("Success", item.DisplayName);
            Assert.AreEqual("worked_successfully", item.Description);
        }

        [Test]
        public void ResponseStatus_Failed()
        {
            var item = ResponseStatus.Failed;

            Assert.AreEqual(2, item.Value);
            Assert.AreEqual("Failed", item.DisplayName);
            Assert.AreEqual("request_failed", item.Description);
        }

        [Test]
        public void ResponseStatus_Invalid()
        {
            var item = ResponseStatus.Invalid;

            Assert.AreEqual(3, item.Value);
            Assert.AreEqual("Invalid", item.DisplayName);
            Assert.AreEqual("request_not_valid", item.Description);
        }

        [Test]
        public void ResponseStatus_InvalidBecauseEntityNotFound()
        {
            var item = ResponseStatus.InvalidBecauseEntityNotFound;

            Assert.AreEqual(4, item.Value);
            Assert.AreEqual("InvalidBecauseEntityNotFound", item.DisplayName);
            Assert.AreEqual("request_failed_because_entity_not_found", item.Description);
        }

        [Test]
        public void ResponseStatus_SuccessWithProblems()
        {
            var item = ResponseStatus.SuccessWithProblems;

            Assert.AreEqual(5, item.Value);
            Assert.AreEqual("SuccessWithProblems", item.DisplayName);
            Assert.AreEqual("worked_successfully_but_some_parts_are_missing_check_messages", item.Description);
        }

        [Test]
        public void ResponseStatus_Has_6_Items()
        {
            var items = Enumeration.GetAll<ResponseStatus>();

            Assert.AreEqual(6, items.Count);
            Assert.True(items.Contains(ResponseStatus.Unknown));
            Assert.True(items.Contains(ResponseStatus.Success));
            Assert.True(items.Contains(ResponseStatus.Failed));
            Assert.True(items.Contains(ResponseStatus.Invalid));
            Assert.True(items.Contains(ResponseStatus.InvalidBecauseEntityNotFound));
            Assert.True(items.Contains(ResponseStatus.SuccessWithProblems));
        }
    }
}
using NUnit.Framework;

using Snappy.Common.Models.DataTransferObjects;

namespace Snappy.Common.Tests.Models.DataTransferObjects
{
    [TestFixture]
    public class DataTransferObjectsTests
    {
        [Test]
        public void BaseDto_is_abstract()
        {
            Assert.True(typeof(BaseDto).IsAbstract);
        }
    }
}
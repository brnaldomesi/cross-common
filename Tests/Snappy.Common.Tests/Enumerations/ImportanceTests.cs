using NUnit.Framework;

using Snappy.Common.Enumerations;

namespace Snappy.Common.Tests.Enumerations
{
    [TestFixture]
    public class ImportanceTests
    {
        [Test]
        public void Importance_Unknown()
        {
            var item = Importance.Unknown;

            Assert.AreEqual(0, item.Value);
            Assert.AreEqual("Unknown", item.DisplayName);
            Assert.AreEqual(string.Empty, item.Description);
        }

        [Test]
        public void Importance_High()
        {
            var item = Importance.High;

            Assert.AreEqual(1, item.Value);
            Assert.AreEqual("High", item.DisplayName);
            Assert.AreEqual(string.Empty, item.Description);
        }

        [Test]
        public void Importance_Normal()
        {
            var item = Importance.Normal;

            Assert.AreEqual(2, item.Value);
            Assert.AreEqual("Normal", item.DisplayName);
            Assert.AreEqual(string.Empty, item.Description);
        }

        [Test]
        public void Importance_Low()
        {
            var item = Importance.Low;

            Assert.AreEqual(3, item.Value);
            Assert.AreEqual("Low", item.DisplayName);
            Assert.AreEqual(string.Empty, item.Description);
        }

        [Test]
        public void Importance_Has_4_Items()
        {
            var items = Enumeration.GetAll<Importance>();

            Assert.AreEqual(4, items.Count);
            Assert.True(items.Contains(Importance.Unknown));
            Assert.True(items.Contains(Importance.High));
            Assert.True(items.Contains(Importance.Normal));
            Assert.True(items.Contains(Importance.Low));
        }
    }
}
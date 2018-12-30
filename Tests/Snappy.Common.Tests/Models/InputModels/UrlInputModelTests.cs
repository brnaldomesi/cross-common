using NUnit.Framework;

using Snappy.Common.Models.InputModels;

namespace Snappy.Common.Tests.Models.InputModels
{
    [TestFixture]
    public class UrlInputModelTests
    {
        [TestCase("name", "label", true, "value")]
        [TestCase("name", "label", false, "value")]
        public void UrlInputModel(string name, string labelKey, bool isRequired, string value)
        {
            var model = new UrlInputModel(name, labelKey, isRequired, value);

            Assert.AreEqual(name, model.Name);
            Assert.AreEqual(labelKey, model.LabelKey);
            Assert.AreEqual(isRequired, model.IsRequired);
            Assert.AreEqual(value, model.Value);
        }
    }
}
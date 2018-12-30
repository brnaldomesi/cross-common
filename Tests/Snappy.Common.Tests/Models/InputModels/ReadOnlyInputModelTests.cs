using NUnit.Framework;

using Snappy.Common.Models.InputModels;

namespace Snappy.Common.Tests.Models.InputModels
{
    [TestFixture]
    public class ReadOnlyInputModelTests
    {
        [TestCase("name", "label", true, "value")]
        [TestCase("name", "label", false, "value")]
        public void ReadOnlyInputModel(string name, string labelKey, bool isRequired, string value)
        {
            var model = new ReadOnlyInputModel(labelKey, value);

            Assert.AreEqual(labelKey, model.LabelKey);
            Assert.AreEqual(value, model.Value);
        }
    }
}
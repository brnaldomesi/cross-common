using NUnit.Framework;

using Snappy.Common.Models.InputModels;

namespace Snappy.Common.Tests.Models.InputModels
{
    [TestFixture]
    public class TextareaInputModelTests
    {
        [TestCase("name", "label", true, "value")]
        [TestCase("name", "label", false, "value")]
        public void TextareaInputModel(string name, string labelKey, bool isRequired, string value)
        {
            var model = new TextareaInputModel(name, labelKey, isRequired, value);

            Assert.AreEqual(name, model.Name);
            Assert.AreEqual(labelKey, model.LabelKey);
            Assert.AreEqual(isRequired, model.IsRequired);
            Assert.AreEqual(value, model.Value);
        }
    }
}
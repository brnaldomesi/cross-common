using NUnit.Framework;
using Snappy.Common.Client.Models.InputModels;

namespace Snappy.Common.Tests.Models.InputModels
{
    [TestFixture]
    public class CheckboxInputModelTests
    {
        [TestCase(BaseTestDataHelper.STRING, TestDataHelper.STRING_1, true, true, true)]
        [TestCase(BaseTestDataHelper.STRING, TestDataHelper.STRING_1, true, false, false)]
        [TestCase(BaseTestDataHelper.STRING, TestDataHelper.STRING_1, true, true, false)]
        [TestCase(BaseTestDataHelper.STRING, TestDataHelper.STRING_1, false, false, false)]
        public void CheckboxInputModel(string name, string labelKey, bool isRequired, bool isReadOnly, bool value)
        {
            var model = new CheckboxInputModel(name, labelKey, isRequired, isReadOnly, value);

            Assert.AreEqual(name, model.Name);
            Assert.AreEqual(labelKey, model.LabelKey);
            Assert.AreEqual(isRequired, model.IsRequired);
            Assert.AreEqual(isReadOnly, model.IsReadOnly);
            Assert.AreEqual(value, model.Value);
        }
    }
}
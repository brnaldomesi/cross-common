﻿using NUnit.Framework;

using Snappy.Common.Models.InputModels;

namespace Snappy.Common.Tests.Models.InputModels
{
    [TestFixture]
    public class FileInputModelTests
    {
        [TestCase("name", "label", true, true, "value")]
        [TestCase("name", "label", false, false, "value")]
        public void FileInputModel(string name, string labelKey, bool isRequired, bool isMultiple, string value)
        {
            var model = new FileInputModel(name, labelKey, isRequired, isMultiple, value);

            Assert.AreEqual(name, model.Name);
            Assert.AreEqual(labelKey, model.LabelKey);
            Assert.AreEqual(isRequired, model.IsRequired);
            Assert.AreEqual(isMultiple, model.IsMultiple);
            Assert.AreEqual(value, model.Value);
        }
    }
}
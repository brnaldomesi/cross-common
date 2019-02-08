using NUnit.Framework;
using Shouldly;

using Snappy.Common.Client.Models.ViewModels;

namespace Snappy.Common.Tests.Models.ViewModels
{
    [TestFixture]
    public class BaseModelTests
    {
        [Test]
        public void BaseModel_is_abstract()
        {
            typeof(BaseModel).IsAbstract.ShouldBeTrue();
        }

        [Test]
        public void BaseModel_has_SetInputModelValues()
        {
            var methodInfo = typeof(BaseModel).GetMethod("SetInputModelValues");
            methodInfo.ShouldSatisfyAllConditions(() => methodInfo.IsVirtual.ShouldBeTrue(),
                                                  () => methodInfo.ReturnType.ShouldBe(typeof(void)));
        }

        [Test]
        public void BaseModel_has_SetInputErrorMessages()
        {
            var methodInfo = typeof(BaseModel).GetMethod("SetInputErrorMessages");
            methodInfo.ShouldSatisfyAllConditions(() => methodInfo.IsVirtual.ShouldBeTrue(),
                () => methodInfo.ReturnType.ShouldBe(typeof(void)));
        }

        [Test]
        public void TestModel_Properties()
        {
            var model = new TestModel();

            model.ShouldSatisfyAllConditions(() => model.ErrorMessages.ShouldNotBeNull(),
                                             () => model.WarningMessages.ShouldNotBeNull(),
                                             () => model.SuccessMessages.ShouldNotBeNull(),
                                             () => model.InputErrorMessages.ShouldNotBeNull(),

                                             () => model.ErrorMessages.Count.ShouldBe(0),
                                             () => model.WarningMessages.Count.ShouldBe(0),
                                             () => model.SuccessMessages.Count.ShouldBe(0),
                                             () => model.InputErrorMessages.Count.ShouldBe(0),

                                             () => string.IsNullOrEmpty(model.Title).ShouldBeTrue(),

                                             () => model.IsValid().ShouldBeTrue(),
                                             () => model.IsNotValid().ShouldBeFalse());
        }
    }
}
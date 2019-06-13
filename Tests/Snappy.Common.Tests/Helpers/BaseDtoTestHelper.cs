using System;
using System.Linq;
using System.Reflection;


using Shouldly;

namespace Snappy.Common.Tests.Helpers
{
    public class BaseEntityTestHelper
    {
        public void AssertInstantProperty(PropertyInfo[] properties, string propertyName, DateTime propertyValue)
        {
            propertyValue.ShouldNotBeNull();

            var propertyInfo = properties.First(x => x.Name == propertyName);
            propertyInfo.PropertyType.ShouldBe(typeof(DateTime));
        }

        public void AssertNullableInstantProperty(PropertyInfo[] properties, string propertyName, DateTime? propertyValue)
        {
            propertyValue.ShouldBeNull();

            var propertyInfo = properties.First(x => x.Name == propertyName);
            propertyInfo.PropertyType.ShouldBe(typeof(DateTime?));
        }

        public void AssertStringProperty(PropertyInfo[] properties, string propertyName, string propertyValue)
        {
            string.IsNullOrEmpty(propertyValue).ShouldBeTrue();

            var propertyInfo = properties.First(x => x.Name == propertyName);
            propertyInfo.PropertyType.Name.ShouldBe(nameof(String));
        }

        public void AssertBooleanProperty(PropertyInfo[] properties, string propertyName, bool propertyValue)
        {
            propertyValue.ShouldBeFalse();

            var propertyInfo = properties.First(x => x.Name == propertyName);
            propertyInfo.PropertyType.Name.ShouldBe(nameof(Boolean));
        }

        public void AssertIntegerProperty(PropertyInfo[] properties, string propertyName, int propertyValue)
        {
            propertyValue.ShouldBe(0);

            var propertyInfo = properties.First(x => x.Name == propertyName);
            propertyInfo.PropertyType.Name.ShouldBe(nameof(Int32));
        }

        public void AssertLongProperty(PropertyInfo[] properties, string propertyName, long propertyValue)
        {
            propertyValue.ShouldBe(0);

            var propFirstName = properties.First(x => x.Name == propertyName);
            propFirstName.PropertyType.Name.ShouldBe(nameof(Int64));
        }

        public void AssertGuidProperty(PropertyInfo[] properties, string propertyName, Guid propertyValue)
        {
            propertyValue.ToString().ShouldBe("00000000-0000-0000-0000-000000000000");

            var propFirstName = properties.First(x => x.Name == propertyName);
            propFirstName.PropertyType.Name.ShouldBe(nameof(Guid));
        }
    }
}
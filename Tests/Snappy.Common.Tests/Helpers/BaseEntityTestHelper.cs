﻿using System;
using System.Linq;
using System.Reflection;

using NodaTime;
using Shouldly;
using Snappy.Common.Models.DataTransferObjects;

namespace Snappy.Common.Tests.Helpers
{
    public class BaseDtoTestHelper
    {
        public void AssertInstantProperty(PropertyInfo[] properties, string propertyName, Instant propertyValue)
        {
            propertyValue.ShouldNotBeNull();

            var propertyInfo = properties.First(x => x.Name == propertyName);
            propertyInfo.PropertyType.ShouldBe(typeof(Instant));
        }

        public void AssertNullableInstantProperty(PropertyInfo[] properties, string propertyName, Instant? propertyValue)
        {
            propertyValue.ShouldBeNull();

            var propertyInfo = properties.First(x => x.Name == propertyName);
            propertyInfo.PropertyType.ShouldBe(typeof(Instant?));
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

        public void AssertDoubleProperty(PropertyInfo[] properties, string propertyName, double propertyValue)
        {
            propertyValue.ShouldBe(0);

            var propFirstName = properties.First(x => x.Name == propertyName);
            propFirstName.PropertyType.Name.ShouldBe(nameof(Double));
        }

        public void AssertGuidProperty(PropertyInfo[] properties, string propertyName, Guid propertyValue)
        {
            propertyValue.ToString().ShouldBe("00000000-0000-0000-0000-000000000000");

            var propFirstName = properties.First(x => x.Name == propertyName);
            propFirstName.PropertyType.Name.ShouldBe(nameof(Guid));
        }

        public void AssertNullableGuidProperty(PropertyInfo[] properties, string propertyName, Guid? propertyValue)
        {
            propertyValue.ToString().ShouldBe("");

            var propFirstName = properties.First(x => x.Name == propertyName);
            propFirstName.PropertyType.Name.ShouldBe("Nullable`1");
        }

        protected static void AssertBaseDto(Type entityType)
        {
            var type = entityType.BaseType;
            var baseType = type;
            var isContinue = true;
            while (isContinue)
            {
                if (type == typeof(object))
                {
                    baseType.IsAssignableFrom(typeof(BaseDto)).ShouldBeTrue();
                    isContinue = false;
                }

                baseType = type;
                type = type.BaseType;
            }
        }
    }
}
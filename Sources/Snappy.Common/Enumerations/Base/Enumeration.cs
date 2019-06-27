using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Snappy.Common.Helpers;

namespace Snappy.Common.Enumerations.Base
{
    [Serializable]
    public abstract class Enumeration : IComparable
    {
        public int Value { get; }
        public string DisplayName { get; }
        public string Description { get; }

        protected Enumeration() { }
        protected Enumeration(int value, string displayName, string description = "")
        {
            Value = value;
            DisplayName = displayName;
            Description = description;
        }

        public override string ToString()
        {
            return DisplayName;
        }

        public static List<T> GetAll<T>()
               where T : Enumeration
        {
            var fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
            return fields.Select(f => f.GetValue(null)).Cast<T>().ToList();
        }

        public static T Get<T>(Guid uid)
            where T : Enumeration, IEnumerationWithUid
        {
            var item = GetAll<T>().Find(x => x.Uid == uid);

            return item;
        }

        public static T Get<T>(string displayName)
            where T : Enumeration
        {
            var item = GetAll<T>().Find(x => x.DisplayName == displayName);

            return item;
        }

        public override bool Equals(object obj)
        {
            var otherValue = obj as Enumeration;
            if (otherValue == null)
            {
                return false;
            }

            var typeMatches = GetType() == obj.GetType();
            var valueMatches = Value.Equals(otherValue.Value);

            return typeMatches && valueMatches;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public static bool IsValueNotValid<T>(int value) where T : Enumeration
        {
            var fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
            for (var i = 0; i < fields.Length; i++)
            {
                var field = fields[i];
                if (field.GetValue(null).ToString() == FromValue<T>(value).ToString())
                {
                    return false;
                }
            }

            return true;
        }

        public static T FromValue<T>(int value) where T : Enumeration
        {
            var matchingItem = Parse<T, int>(value, "value", item => item.Value == value);
            return matchingItem;
        }

        public static T FromDisplayName<T>(string displayName) where T : Enumeration
        {
            var matchingItem = Parse<T, string>(displayName, "display name", item => item.DisplayName == displayName);
            return matchingItem;
        }

        private static T Parse<T, K>(K value, string description, Func<T, bool> predicate) where T : Enumeration
        {
            var matchingItem = GetAll<T>().FirstOrDefault(predicate);
            if (matchingItem == null)
            {
                var message = $"'{value}' is not a valid {description} in {typeof(T)}";
                throw new ApplicationException(message);
            }

            return matchingItem;
        }

        public int CompareTo(object other)
        {
            return Value.CompareTo(((Enumeration)other).Value);
        }
    }
}
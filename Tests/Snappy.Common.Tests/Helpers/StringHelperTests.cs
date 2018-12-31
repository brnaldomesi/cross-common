using System;

using NUnit.Framework;

using Snappy.Common.Helpers;

namespace Snappy.Common.Tests.Helpers
{
    [TestFixture]
    public class StringHelperTests
    {
        [TestCase("can")]
        [TestCase("can_caliskan")]
        public void StringHelper_IsAlphabeticalOrUnderscore(string text)
        {
            Assert.True(text.IsAlphabeticalOrUnderscore());
        }

        [TestCase("Can12345")]
        [TestCase("Can12345*")]
        public void StringHelper_IsValidPassword(string text)
        {
            Assert.True(text.IsValidPassword());
        }

        [TestCase("cancaliskan")]
        [TestCase("12345678")]
        [TestCase("CANCALISKAN")]
        [TestCase("can112345656")]
        [TestCase("Cancasdasdcas")]
        [TestCase("CAN1SDFSLKDJFKLS")]
        [TestCase("Can1")]
        public void StringHelper_IsNotValidPassword(string text)
        {
            Assert.True(text.IsNotValidPassword());
        }

        [TestCase("can@can.com")]
        [TestCase("can.caliskan@can.com")]
        public void StringHelper_IsEmail(string text)
        {
            Assert.True(text.IsEmail());
        }

        [TestCase("cancan.com")]
        [TestCase("cancancom")]
        [TestCase(".com")]
        public void StringHelper_IsNotEmail(string text)
        {
            Assert.True(text.IsNotEmail());
        }

        [TestCase("f3feeac7332e4dadbdfbf14964470f43")]
        [TestCase("D9485A35-A270-4C30-BDF8-80D0CA86DD2C")]
        [TestCase("CA125BE1158C4F768EA1A93A391868BD")]
        [TestCase("97bb402f-3cd6-4882-a8ab-d745ef683825")]
        public void StringHelper_IsUid(string text)
        {
            Assert.True(text.IsUid());
        }

        [TestCase("can")]
        public void StringHelper_IsNotUid(string text)
        {
            Assert.True(text.IsNotUid());
        }

        [TestCase("5f970aca-f83f-4779-b78c-b7b081f5a9")]
        [TestCase("can")]
        public void StringHelper_ValidateUid(string text)
        {
            Assert.Throws<ArgumentException>(text.ValidateUid);
        }

        [Test]
        public void StringHelper_GetNewUid()
        {
            var result = StringHelper.GetNewUid();
            Assert.IsNotNull(result);
            Assert.True(result.IsUid());
        }

        [TestCase("")]
        [TestCase(" ")]
        [TestCase("    ")]
        [TestCase(null)]
        public void StringHelper_IsEmpty(string text)
        {
            Assert.True(text.IsEmpty());
        }

        [TestCase("can")]
        public void StringHelper_IsNotEmpty(string text)
        {
            Assert.True(text.IsNotEmpty());
        }

        [TestCase("http://www.google.com")]
        [TestCase("https://hype.games/")]
        [TestCase("http://hype.games/")]
        [TestCase("http://hype.games")]
        public void StringHelper_IsUrl(string text)
        {
            Assert.True(text.IsUrl());
        }

        [TestCase("www.google.com")]
        [TestCase("google.com")]
        [TestCase("asdasd")]
        public void StringHelper_IsNotUrl(string text)
        {
            Assert.True(text.IsNotUrl());
        }
    }
}

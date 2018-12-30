using System;

using NUnit.Framework;

using Snappy.Common.Helpers;

namespace Snappy.Common.Tests.Helpers
{
    [TestFixture]
    public class CryptoHelperTests
    {
        [Test]
        public void CryptoHelper_GetRandomNumber()
        {
            // arrange
            var helper = GetCryptoHelper();

            // act
            var result = helper.GetRandomNumber();

            // assert
            Assert.Greater(result, 0);
        }

        [Test]
        public void CryptoHelper_GetRandomData()
        {
            // arrange
            var helper = GetCryptoHelper();
            var bits = 512;

            // act
            var result = helper.GetRandomData(bits);

            // assert
            Assert.IsAssignableFrom<byte[]>(result);
            Assert.AreEqual(result.Length, bits / 8);
            Assert.AreEqual(helper.ConvertToString(result), Convert.ToBase64String(result));
        }

        [Test]
        public void CryptoHelper_GetSalt()
        {
            // arrange
            var helper = GetCryptoHelper();

            // act
            var result = helper.GetSalt();

            // assert
            Assert.IsAssignableFrom<byte[]>(result);
            Assert.AreEqual(result.Length, 128 / 8);
            Assert.AreEqual(helper.ConvertToString(result), Convert.ToBase64String(result));
        }

        [Test]
        public void CryptoHelper_GetKey()
        {
            // arrange
            var helper = GetCryptoHelper();

            // act
            var result = helper.GetKey();

            // assert
            Assert.IsAssignableFrom<byte[]>(result);
            Assert.AreEqual(result.Length, 256 / 8);
            Assert.AreEqual(helper.ConvertToString(result), Convert.ToBase64String(result));
        }

        [Test]
        public void CryptoHelper_GetIV()
        {
            // arrange
            var helper = GetCryptoHelper();

            // act
            var result = helper.GetIV();

            // assert
            Assert.IsAssignableFrom<byte[]>(result);
            Assert.AreEqual(result.Length, 128 / 8);
            Assert.AreEqual(helper.ConvertToString(result), Convert.ToBase64String(result));
        }

        [Test]
        public void CryptoHelper_GetSaltAsString()
        {
            // arrange
            var helper = GetCryptoHelper();

            // act
            var result = helper.GetSaltAsString();

            // assert
            Assert.IsNotEmpty(result);
            Assert.IsAssignableFrom<string>(result);
        }

        [Test]
        public void CryptoHelper_ConvertToString()
        {
            // arrange
            var helper = GetCryptoHelper();
            var salt = helper.GetSalt();
            var expected = Convert.ToBase64String(salt);

            // act
            var result = helper.ConvertToString(salt);

            // assert
            Assert.IsAssignableFrom<string>(result);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CryptoHelper_ConvertToByteArray()
        {
            // arrange
            var helper = GetCryptoHelper();
            var salt = helper.GetSaltAsString();
            var expected = Convert.FromBase64CharArray(salt.ToCharArray(), 0, salt.Length);

            // act
            var result = helper.ConvertToByteArray(salt);

            // assert
            Assert.IsAssignableFrom<byte[]>(result);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CryptoHelper_Hash()
        {
            // arrange
            var helper = GetCryptoHelper();
            var salt = helper.GetSaltAsString();
            var random = helper.GetRandomNumber().ToString();

            // act
            var result = helper.Hash(random, salt);

            // assert
            Assert.IsAssignableFrom<string>(result);

            for (var i = 0; i < 10; i++)
            {
                Assert.AreEqual(result, helper.Hash(random, salt));
            }
        }

        [Test]
        public void CryptoHelper_Encrypt_Decrypt()
        {
            // arrange
            var helper = GetCryptoHelper();

            var key = helper.GetKey();
            var iv = helper.GetIV();
            const string plainText = "plain test string çöşiğü +?-*^#@€£";

            for (var i = 0; i < 5; i++)
            {
                // act
                var encrypted = helper.Encrypt(plainText, key, iv);
                var decrypted = helper.Decrypt(encrypted, key, iv);

                // assert
                Assert.AreEqual(plainText, decrypted);
            }
        }

        private static CryptoHelper GetCryptoHelper()
        {
            return new CryptoHelper();
        }
    }
}
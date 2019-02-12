using NUnit.Framework;

using Snappy.Common.Helpers;

namespace Snappy.Common.Tests.Helpers
{
    [TestFixture]
    public class UidHelperTests
    {
        [Test]
        public void UidHelper()
        {
            var cryptoHelper = new CryptoHelper();
            var uidHelper = new UidHelper(cryptoHelper);

            var obfuscationKey = cryptoHelper.ConvertToString(cryptoHelper.GetKey());
            var obfuscationIV = cryptoHelper.ConvertToString(cryptoHelper.GetIV());

            var recordId = 5;
            var parent1 = 23;
            var parent2 = 152;
            var parent3 = 45;
            var uid = uidHelper.GetUidFromId(obfuscationKey, obfuscationIV, recordId, parent1, parent2, parent3);
            Assert.IsNotEmpty(uid);

            var id = uidHelper.GetIdFromUid(obfuscationKey, obfuscationIV, uid, parent1, parent2, parent3);
            Assert.AreEqual(recordId, id);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Snappy.Common.Helpers
{
    public class UidHelper
    {
        public string CacheCategoryName { get; }

        private const string ID_SEPERATOR = "~";
        private const string PARENT_ID_SEPERATOR = "|";

        private readonly CryptoHelper _cryptoHelper;

        public UidHelper(CryptoHelper cryptoHelper)
        {
            _cryptoHelper = cryptoHelper;
            CacheCategoryName = nameof(UidHelper);
        }

        public long GetIdFromUid(string obfuscationKey, string obfuscationIV, string recordUid)
        {
            var decrypt = _cryptoHelper.Decrypt(recordUid, obfuscationKey, obfuscationIV);
            var idString = decrypt.Split(ID_SEPERATOR, StringSplitOptions.RemoveEmptyEntries).ToList().Last();
            var id = Convert.ToInt64(idString);
            return id;
        }

        public List<long> GetIdsFromUid(string obfuscationKey, string obfuscationIV, string recordUid)
        {
            var decrypt = _cryptoHelper.Decrypt(recordUid, obfuscationKey, obfuscationIV);
            var ids = decrypt.Split(ID_SEPERATOR, StringSplitOptions.RemoveEmptyEntries);
            var result = new List<long>();
            foreach (var id in ids)
            {
                result.Add(Convert.ToInt64(id));
            }
            return result;
        }

        public string GetUidFromId(string obfuscationKey, string obfuscationIV, long recordId)
        {
            var preparedId = PrepareId(recordId, null);
            var encrypt = _cryptoHelper.Encrypt(preparedId, obfuscationKey, obfuscationIV);
            return encrypt;
        }

        public string GetUidFromId(string obfuscationKey, string obfuscationIV, long recordId, params long[] parentIds)
        {
            var preparedId = PrepareId(recordId, parentIds);
            var encrypt = _cryptoHelper.Encrypt(preparedId, obfuscationKey, obfuscationIV);
            return encrypt;
        }

        public string PrepareId(long recordId, long[] parentIds)
        {
            if (parentIds == null)
            {
                return recordId.ToString();
            }

            var prefix = string.Join(PARENT_ID_SEPERATOR, parentIds.Select(x => x.ToString()).ToArray());
            var id = prefix + ID_SEPERATOR + recordId;
            return id;
        }
    }
}
using System;
using System.Collections.Generic;

namespace Snappy.Common.Models.Responses
{
    public class LabelInfo
    {
        public Guid uid { get; set; }
        public string key { get; set; }
        public List<TranslationInfo> translations { get; set; }

        public LabelInfo()
        {
            translations = new List<TranslationInfo>();
        }
    }
}
using System;

namespace Snappy.Common.Models.Requests
{
    public class ParameterListInfo
    {
        public string ParameterGroupName { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set; }
    }
}
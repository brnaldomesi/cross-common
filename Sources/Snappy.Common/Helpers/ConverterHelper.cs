using System;

namespace Snappy.Common.Helpers
{
    public static class ConverterHelper
    {
        public static double ConvertBytesToMegabytes(this long bytes)
        {
            return Math.Round(((bytes / 1024f) / 1024f), 2);
        }
    }
}
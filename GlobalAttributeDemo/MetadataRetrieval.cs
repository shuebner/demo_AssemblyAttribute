using System;
using System.Reflection;

namespace GlobalAttributeDemo
{
    public static class MetadataRetrieval
    {
        static readonly Assembly AssemblyWithMetadataAttribute = typeof(MetadataRetrieval).Assembly;

        static readonly MyMetadataAttribute MetadataAttribute = AssemblyWithMetadataAttribute.GetCustomAttribute<MyMetadataAttribute>()
            ?? throw new InvalidOperationException("expected metadata attribute to be defined, but it was not");

        public static string SomeString => MetadataAttribute.SomeString;

        public static Version SomeVersion => MetadataAttribute.SomeVersion;

        public static DateTimeOffset SomeTimestamp => MetadataAttribute.SomeTimestamp;
    }
}
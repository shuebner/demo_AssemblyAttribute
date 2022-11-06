using System;

namespace GlobalAttributeDemo
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
    public sealed class MyMetadataAttribute : Attribute
    {
        public MyMetadataAttribute(
            string someString,
            string someVersion,
            string someTimestamp)
        {
            SomeString = someString;
            SomeVersion = Version.Parse(someVersion);
            SomeTimestamp = DateTimeOffset.Parse(someTimestamp);
        }

        public string SomeString { get; }

        public Version SomeVersion { get; }

        public DateTimeOffset SomeTimestamp { get; }
    }
}
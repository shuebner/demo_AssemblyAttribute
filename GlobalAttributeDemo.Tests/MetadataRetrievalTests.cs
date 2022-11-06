namespace GlobalAttributeDemo.Tests;

public class MetadataRetrievalTests
{
    [Test]
    public void String_Can_be_retrieved()
    {
        Assert.That(MetadataRetrieval.SomeString, Is.EqualTo("Hello"));
    }

    [Test]
    public void Version_Can_be_retrieved()
    {
        Assert.That(MetadataRetrieval.SomeVersion, Is.EqualTo(new Version(1, 2, 3, 4)));
    }

    [Test]
    public void Timestamp_Can_be_retrieved()
    {
        Assert.That(MetadataRetrieval.SomeTimestamp, Is.EqualTo(new DateTimeOffset(2022, 11, 6, 12, 12, 23, TimeSpan.Zero)));
    }
}
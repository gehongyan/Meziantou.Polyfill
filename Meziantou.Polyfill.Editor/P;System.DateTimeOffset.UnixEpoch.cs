// XML-DOC: F:System.DateTimeOffset.UnixEpoch
using System;

static partial class PolyfillExtensions
{
    extension(DateTimeOffset)
    {
        public static DateTimeOffset UnixEpoch => new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);
    }
}

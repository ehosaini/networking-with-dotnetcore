using System;



namespace networking_with_dotnetcore
{
    public static class Uri
    {
        public static System.Uri GetSimpleUri()
        {
            // var builder = new UriBuilder();
            // builder.Scheme = "http";
            // builder.Host = "test.com";
            var builder = new UriBuilder("https", "test.com", 8000, "some-path");
            return builder.Uri;
        }
    }
}


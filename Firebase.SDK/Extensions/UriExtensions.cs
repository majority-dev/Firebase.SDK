using System;

namespace Firebase.SDK.Extensions;

public static class UriExtensions
{
    public static Uri Append(this Uri baseUri, string relativeUrl)
    {
        var baseUrl = baseUri.AbsoluteUri;

        if (string.IsNullOrWhiteSpace(relativeUrl))
            return new Uri(baseUrl);

        baseUrl = baseUrl.TrimEnd('/');
        relativeUrl = relativeUrl.TrimStart('/');

        return new Uri($"{baseUrl}/{relativeUrl}");
    }
}
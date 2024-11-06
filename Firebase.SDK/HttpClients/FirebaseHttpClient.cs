using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Firebase.SDK.Configuration;
using Firebase.SDK.Extensions;
using Firebase.SDK.Firebase.Auth.ServiceAccounts;

namespace Firebase.SDK.HttpClients;

internal abstract class FirebaseHttpClient : IFirebaseHttpClient
{
    protected readonly Uri Authority;
    protected readonly IHttpClientProxy Client;
    protected readonly FirebaseSDKConfiguration Configuration;
    protected readonly IServiceAccountCredentials Credentials;

    protected FirebaseHttpClient(IServiceAccountCredentials credentials, FirebaseSDKConfiguration configuration,
        Uri authority = null)
    {
        Credentials = credentials;
        Configuration = configuration;
        Authority = authority;
        Client = Configuration.HttpClientProxy(configuration);
    }

    public Uri GetAuthority()
    {
        return Authority;
    }

    protected void AddAuthHeaders(HttpRequestMessage request)
    {
        if (request == null) throw new ArgumentNullException(nameof(request));

        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Configuration.AccessToken?.AccessToken);
    }

    protected Uri GetFullAbsoluteUrl(Uri uri)
    {
        if (Authority == null && !uri.IsAbsoluteUri)
            throw new ArgumentOutOfRangeException(nameof(uri), "If Authority is missing uri should be absolute");

        if (uri.IsAbsoluteUri) return uri;

        return Authority == null ? uri : Authority.Append(uri.ToString());
    }

    protected Task<string> SendAsync(Func<HttpRequestMessage> requestMessage)
    {
        return Client.SendAsync(requestMessage);
    }
}
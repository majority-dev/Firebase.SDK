namespace Firebase.SDK.Firebase.CloudMessaging
{
    #region Namespace Imports

    using System.Threading.Tasks;

    using Configuration;
    using Firebase.Auth.ServiceAccounts;
    using Firebase.CloudMessaging.Models;
    using HttpClients.CloudMessaging;

    #endregion


    internal class FirebaseCloudMessaging : IFirebaseCloudMessaging
    {
        private readonly ICloudMessagingHttpClient _httpClient;

        public FirebaseCloudMessaging(IServiceAccountCredentials credentials, FirebaseSDKConfiguration configuration)
            => _httpClient = new CloudMessagingHttpClient(credentials, configuration);

        public async Task<PushMessageResponse> SendCloudMessageAsync(FirebasePushMessage request, bool dryRun = false)
        {
            var message = new FirebasePushMessageEnvelope { DryRun = dryRun, Message = request };
            return await _httpClient.SendCloudMessageAsync(message).ConfigureAwait(false);
        }
    }
}
﻿namespace FirebaseCoreSDK.Firebase.CloudMessaging
{
    #region Namespace Imports

    using System;
    using System.Threading.Tasks;

    using FirebaseCoreSDK.Configuration;
    using FirebaseCoreSDK.Firebase.Auth.ServiceAccounts;
    using FirebaseCoreSDK.Firebase.CloudMessaging.Models;
    using FirebaseCoreSDK.HttpClients.CloudMessaging;

    #endregion


    internal class FirebaseCloudMessaging : IFirebaseCloudMessaging
    {
        private readonly ICloudMessagingHttpClient _httpClient;

        public FirebaseCloudMessaging(IServiceAccountCredentials credentials, FirebaseSDKConfiguration configuration)
            => _httpClient = new CloudMessagingHttpClient(credentials, configuration);

        ~FirebaseCloudMessaging() => Dispose(false);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<PushMessageResponse> SendCloudMessageAsync(FirebasePushMessage request, bool dryRun = false)
        {
            var message = new FirebasePushMessageEnvelope { DryRun = dryRun, Message = request };
            return await _httpClient.SendCloudMessageAsync(message).ConfigureAwait(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
            {
                return;
            }

            _httpClient?.Dispose();
        }
    }
}
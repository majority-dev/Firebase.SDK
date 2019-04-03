﻿namespace FirebaseCoreSDK.HttpClients.CloudMessaging
{
    #region Namespace Imports

    using System.Threading.Tasks;

    using FirebaseCoreSDK.Firebase.CloudMessaging.Models;

    #endregion


    internal interface ICloudMessagingHttpClient : IHttpClient
    {
        Task<PushMessageResponse> SendCloudMessageAsync(FirebasePushMessageEnvelope request);
    }
}
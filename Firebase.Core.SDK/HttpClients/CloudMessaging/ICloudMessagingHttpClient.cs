namespace Firebase.Core.SDK.HttpClients.CloudMessaging
{
    #region Namespace Imports

    using System.Threading.Tasks;

    using Firebase.CloudMessaging.Models;

    #endregion


    internal interface ICloudMessagingHttpClient : IFirebaseHttpClient
    {
        Task<PushMessageResponse> SendCloudMessageAsync(FirebasePushMessageEnvelope request);
    }
}
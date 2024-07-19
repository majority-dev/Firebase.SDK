namespace Firebase.SDK.Firebase.CloudMessaging
{
    #region Namespace Imports

    using System;
    using System.Threading.Tasks;

    using Firebase.CloudMessaging.Models;

    #endregion


    public interface IFirebaseCloudMessaging
    {
        /// <summary>
        ///     Send Push Notifications
        /// </summary>
        /// <param name="request"></param>
        /// <param name="dryRun">Only test the push message, don't actually send it</param>
        /// <returns></returns>
        Task<PushMessageResponse> SendCloudMessageAsync(FirebasePushMessage request, bool dryRun = false);
    }
}
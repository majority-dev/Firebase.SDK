namespace Firebase.Core.SDK
{
    #region Namespace Imports

    using System;

    using Configuration;
    using Firebase.Auth;
    using Firebase.CloudMessaging;
    using Firebase.Database;
    using Firebase.Storage;

    #endregion


    public interface IFirebaseClient
    {
        IFirebaseAuth Auth { get; }

        IFirebaseCloudMessaging CloudMessaging { get; }
        
        FirebaseSDKConfiguration Configuration { get; }

        IFirebaseDatabase Database { get; }

        IFirebaseStorage Storage { get; }
    }
}
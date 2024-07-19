namespace Firebase.Core.SDK.HttpClients
{
    #region Namespace Imports

    using System;

    #endregion


    public interface IFirebaseHttpClient
    {
        Uri GetAuthority();
    }
}
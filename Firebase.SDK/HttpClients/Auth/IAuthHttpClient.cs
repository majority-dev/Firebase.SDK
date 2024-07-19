namespace Firebase.SDK.HttpClients.Auth
{
    #region Namespace Imports

    using System.Threading.Tasks;

    using Firebase.Auth.Models;

    #endregion


    internal interface IAuthHttpClient : IFirebaseHttpClient
    {
        Task<FirebaseAccessToken> AuthenticateAsync();
        string CreateCustomToken(string userId);
    }
}
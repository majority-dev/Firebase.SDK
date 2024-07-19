// ReSharper disable once CheckNamespace

namespace Firebase.Core.SDK.Firebase.Database
{
    #region Namespace Imports

    using System.Threading.Tasks;

    #endregion


    public static partial class CommandExtensions
    {
        public static async Task DeleteAsync(this IDatabaseRef firebaseRef)
        {
            var databaseRef = (DatabaseRef)firebaseRef;
            // ReSharper disable once AsyncConverter.AsyncAwaitMayBeElidedHighlighting
            await databaseRef.HttpClient.DeletePathAsync(databaseRef.Path).ConfigureAwait(false);
        }
    }
}
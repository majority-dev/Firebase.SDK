﻿// ReSharper disable once CheckNamespace

namespace FirebaseCoreSDK.Firebase.Database
{
    #region Namespace Imports

    using System;
    using System.Threading.Tasks;

    #endregion


    public static partial class CommandExtensions
    {
        /// <exception cref="ArgumentNullException"><paramref name="content" /> is <see langword="null" /></exception>
        public static Task<T> SetAsync<T>(this IDatabaseRef firebaseRef, T content)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            var databaseRef = (DatabaseRef)firebaseRef;
            return databaseRef.HttpClient.SetToPathAsync(databaseRef.Path, content);
        }
    }
}
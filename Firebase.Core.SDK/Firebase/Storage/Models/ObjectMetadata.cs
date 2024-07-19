namespace Firebase.Core.SDK.Firebase.Storage.Models
{
    #region Namespace Imports

    using System;

    #endregion


    public class ObjectMetadata
    {
        public string ContentType { get; set; }
        public string Md5Hash { get; set; }
        public long Size { get; set; }
        public DateTime TimeCreated { get; set; }
    }
}
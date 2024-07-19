namespace Firebase.Core.SDK.Firebase.Database
{
    #region Namespace Imports

    using Newtonsoft.Json;

    #endregion


    public interface IKeyEntity
    {
        [JsonIgnore]
        string Key { get; set; }
    }
}
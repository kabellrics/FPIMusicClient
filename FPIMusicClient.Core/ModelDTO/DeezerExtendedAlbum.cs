using System = System;

namespace FPIMusicClient.Core.ModelDTO
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class DeezerExtendedAlbum
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; set; }

        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("autoPlaylistElementType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AutoPlaylistElementType AutoPlaylistElementType { get; set; }

        [Newtonsoft.Json.JsonProperty("cover", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Cover { get; set; }

        [Newtonsoft.Json.JsonProperty("nbSong", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int NbSong { get; set; }

        [Newtonsoft.Json.JsonProperty("nbPlaylist", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int NbPlaylist { get; set; }

        [Newtonsoft.Json.JsonProperty("nbArtiste", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int NbArtiste { get; set; }

        public string ToJson()
        {

            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings());

        }
        public static DeezerExtendedAlbum FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<DeezerExtendedAlbum>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }
}
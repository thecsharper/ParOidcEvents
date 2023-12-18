using System.Text.Json.Serialization;

namespace WebCodeFlowPkceClient;

public partial class ParOidcEvents
{
    private class ParResponse
    {
        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonPropertyName("request_uri")]
        public string RequestUri { get; set; } = string.Empty;
    }
}
using Newtonsoft.Json;

namespace FluentValidationUnitTests.Classes
{
    public class OregonInformation
    {
        [JsonProperty("zip")]
        public string PostalCode { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("county")]
        public string County { get; set; }
        [JsonProperty("pop")]
        public int Population { get; set; }

        public override string ToString() => PostalCode;

    }
}
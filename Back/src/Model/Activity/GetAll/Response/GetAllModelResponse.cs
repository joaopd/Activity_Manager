using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Model.Activity
{
    public class GetAllModelResponse
    {
        [JsonPropertyName("activities")]
        public List<GetActivityModel> Activities { get; set; }
    }
}

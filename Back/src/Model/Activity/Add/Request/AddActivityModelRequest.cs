using Model.Enums;
using System.Text.Json.Serialization;

namespace Model.Activity
{
    public class AddActivityModelRequest
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("priority")]
        public PriorityEnumModel Priority { get; set; }
    }
}
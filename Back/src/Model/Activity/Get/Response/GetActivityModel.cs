using Model.Enums;
using System;
using System.Text.Json.Serialization;

namespace Model.Activity
{
    public class GetActivityModel
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("number")]
        public int Number { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("priority")]
        public PriorityEnumModel Priority { get; set; }

        [JsonPropertyName("create-date")]
        public DateTime CreateDate { get; set; }

        [JsonPropertyName("complete-date")]
        public DateTime? CompleteDate { get; set; }
    }
}
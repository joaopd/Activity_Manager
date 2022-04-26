using Model.Enums;
using System;
using System.Text.Json.Serialization;

namespace Model.Activity
{
    public class UpdateActivityModelRequest
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("priority")]
        public PriorityEnumModel Priority { get; set; }
    }
}
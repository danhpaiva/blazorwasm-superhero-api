using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorWasmSuperHeroApi.Models
{
    public class Connections
    {
        [JsonPropertyName("group-affiliation")] public string GroupAffiliation { get; set; } = string.Empty;
        [JsonPropertyName("relatives")] public string Relatives { get; set; } = string.Empty;
    }
}
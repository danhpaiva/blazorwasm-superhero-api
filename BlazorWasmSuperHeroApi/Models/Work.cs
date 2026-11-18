using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorWasmSuperHeroApi.Models
{
    public class Work
    {
        [JsonPropertyName("occupation")] public string Occupation { get; set; } = string.Empty;
        [JsonPropertyName("base")] public string Base { get; set; } = string.Empty;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorWasmSuperHeroApi.Models
{
    public class SuperHeroResponse
    {
        [JsonPropertyName("response")]
        public string Response { get; set; } = string.Empty;

        [JsonPropertyName("results-for")]
        public string ResultsFor { get; set; } = string.Empty;

        [JsonPropertyName("results")]
        public List<SuperHero>? Results { get; set; }
    }
}
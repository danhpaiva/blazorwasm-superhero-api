using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorWasmSuperHeroApi.Models
{
    public class ImageInfo
    {
        private string _url = string.Empty;

        [JsonPropertyName("url")]
        public string Url
        {
            get => _url;
            set
            {
                // Remove barras duplas acidentais geradas pela API (exceto no protocolo https://)
                if (!string.IsNullOrEmpty(value))
                {
                    _url = System.Text.RegularExpressions.Regex.Replace(value, "(?<!:)//+", "/");
                }
                else
                {
                    _url = string.Empty;
                }
            }
        }
    }
}
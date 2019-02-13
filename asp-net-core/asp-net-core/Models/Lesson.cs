using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typsy.Demo.Player.Models
{
    public class Lesson
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("instructor")]
        public Instructor Instructor { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("gracePeriod")]
        public int GracePeriod { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}

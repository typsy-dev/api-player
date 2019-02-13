using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_net_core.Models
{
    public class Instructor
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

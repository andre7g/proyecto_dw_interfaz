using MonitoreoBidInterfaz.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MonitoreoBidInterfaz.Models
{
    public class ApiResponse
    {
        public string type { get; set; }
        public string title { get; set; }
        public int status { get; set; }
        public string traceId { get; set; }
        [JsonConverter(typeof(DictionaryStringObjectJsonConverter))]
        public Dictionary<string, object> errors { get; set; }
    }

}


using MonitoreoBidInterfaz.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MonitoreoBidInterfaz.Models
{
    public class DynamicData
    {
        [JsonConverter(typeof(DictionaryStringObjectJsonConverter))]
        public Dictionary<string, object> Data { get; set; }
    }
}

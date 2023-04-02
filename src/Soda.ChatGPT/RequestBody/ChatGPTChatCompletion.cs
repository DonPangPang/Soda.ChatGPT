using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Soda.ChatGPT.RequestBody
{
    public class ChatGPTChatCompletion
    {
        public string model { get; set; } = string.Empty;
        public IEnumerable<string> messages { get; set; } = null!;
        public decimal temperature { get; set; } = 1;
        public decimal top_p { get; set; } = 1;
        public int n { get; set; } = 1;
        public bool stream { get; set; } = false;
        public string? stop { get; set; }
        [JsonIgnore]
        public int max_tokens { get; set; } = 16;
        public decimal presence_penalty { get; set; } = 0;
        public decimal frequency_penalty { get; set; } = 0;
        public Dictionary<string, object>? logit_bias { get; set; }
        public string? user{get; set;}
    }
}
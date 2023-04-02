using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soda.ChatGPT.RequestBody
{
    public class ChatGPTCompletion
    {
        public string model { get; set; } = string.Empty;
        public string? prompt { get; set; }
        public string? suffix { get; set; }
        public decimal max_tokens { get; set; } = 16;
        public decimal temperature { get; set; } = 1;
        public decimal top_p { get; set; } = 1;
        public int n { get; set; } = 1;
        public bool stream { get; set; } = false;
        public int? logprobs { get; set; }
        public bool echo { get; set; } = false;
        public string? stop { get; set; }
        public decimal presence_penalty { get; set; } = 0;
        public decimal frequency_penalty { get; set; } = 0;
        public int best_of { get; set; } = 1;
        public Dictionary<string, object>? logit_bias { get; set; }
        public string? user { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Soda.Http;

namespace Soda.ChatGPT.ResponseBody
{
    public class ChatGPTModel
    {
        public string? id { get; set; }
        public string? @object { get; set; }
        public string? owned_by { get; set; }
        public IEnumerable<object> permission { get; set; } = new List<object>();
    }
}
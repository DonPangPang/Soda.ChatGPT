using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soda.ChatGPT.ResponseBody
{
    public class Completion
    {
        public string? id { get; set; }
        public string? @object { get; set; }
        public TimeSpan created { get; set; }
        public string? model { get; set; }
        public IEnumerable<Choose>? choices { get; set; }
        public Usage? usage { get; set; }
    }

    public class ChatCompletion
    {
        public string? id { get; set; }
        public string? @object { get; set; }
        public TimeSpan created { get; set; }
        public string? model { get; set; }
        public IEnumerable<Choose>? choices { get; set; }
        public Usage? usage { get; set; }
    }

    public class Choose
    {
        public string? text { get; set; }
        public int index { get; set; }
        public object? logprobs { get; set; }
        public string? finish_reason { get; set; }
    }

    public class ChatChoose
    {
        public int index { get; set; }
        public IEnumerable<Message>? message { get; set; }
        public string? finish_reason { get; set; }
    }

    public class Message
    {
        public string? role { get; set; }
        public string? content { get; set; }
    }

    public class Usage
    {
        public int prompt_tokens { get; set; }
        public int completion_tokens { get; set; }
        public int total_tokens { get; set; }
    }
}
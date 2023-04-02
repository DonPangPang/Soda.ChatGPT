using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Soda.Http.Core;

namespace Soda.ChatGPT.Extensions
{
    public static class ChatGPTExtensions
    {
        public static void AddChatGPT()
        {
            QSodaHttp.AddSodaHttp(opts =>
            {
                opts.BaseUrl = "https://api.openai.com";
            });
        }
    }
}
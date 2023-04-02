using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Soda.ChatGPT.Core;
using Soda.ChatGPT.RequestBody;
using Soda.ChatGPT.ResponseBody;
using Soda.Http.Core;

namespace Soda.ChatGPT.Services
{
    public interface IChatGPTModelService
    {
        public Task<IEnumerable<ChatGPTModel>?> GetModels();

        public Task<ChatGPTModel?> GetModel(string id);

        public Task<Completion?> CreateCompletion(ChatGPTCompletion req);

        public Task<ChatCompletion?> CreateChatCompletion(ChatGPTChatCompletion req);
    }

    public class ChatGPTService : IChatGPTModelService
    {
        public enum Actions
        {
            GetModels,
            CreateCompletion,
            CreateChatCompletion
        }

        public UrlMap Urls = new()
        {
            [Actions.GetModels] = "/v1/models",
            [Actions.CreateCompletion] = "/v1/completions",
            [Actions.CreateChatCompletion] = "/v1/chat/completions"
        };

        public async Task<ChatGPTModel?> GetModel(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException($"“{nameof(id)}”不能为 null 或空白。", nameof(id));
            }

            return await QSodaHttp.Uri($"{Urls[Actions.GetModels]}/{id}").GetAsync<ChatGPTModel>();
        }

        public async Task<IEnumerable<ChatGPTModel>?> GetModels()
        {
            return await QSodaHttp.Uri(Urls[Actions.GetModels]).GetAsync<IEnumerable<ChatGPTModel>>();
        }
        public async Task<Completion?> CreateCompletion(ChatGPTCompletion req)
        {
            return await QSodaHttp.Uri(Urls[Actions.CreateCompletion]).Body(req).PostAsync<Completion>();
        }

        public async Task<ChatCompletion?> CreateChatCompletion(ChatGPTChatCompletion req)
        {
            return await QSodaHttp.Uri(Urls[Actions.CreateChatCompletion]).Body(req).PostAsync<ChatCompletion>();
        }
    }
}
using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;

namespace BotSociety.Runtime.Tests
{
    public abstract class BaseTest
    {
        private const HttpRecorderMode mode = HttpRecorderMode.Playback;

        protected const string UserId = "00000000000000000000000000000000";
        protected const string ApiKey = "00000000000000000000000000000000";

        private string ClassName => GetType().FullName;

        private IBotsocietyClient GetClient(DelegatingHandler handler, string userId = UserId, string apiKey = ApiKey)
        {
            var client = new BotsocietyClient(new ApiKeyServiceClientCredentials(userId, apiKey), handlers: handler);
            return client;
        }

        protected void UseClientFor(Func<IBotsocietyClient, Task> doTest, string className = null, [CallerMemberName] string methodName = "")
        {
            using (MockContext context = MockContext.Start(className ?? ClassName, methodName))
            {
                HttpMockServer.Initialize(className ?? ClassName, methodName, mode);
                IBotsocietyClient client = GetClient(HttpMockServer.CreateInstance());
                doTest(client).Wait();
                context.Stop();
            }
        }
    }
}

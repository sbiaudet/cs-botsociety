using System.Threading.Tasks;
using BotSociety.Runtime;
using NUnit.Framework;

namespace BotSociety.Runtime.Tests
{
    public class ApiTests : BaseTest
    {

        private const string conversationId = "5a72e561f34eeb072c293cfd";

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAuth()
        {
            UseClientFor(async client =>
            {
                await client.AuthAsync();
            });
        }

        [Test]
        public void TestListConversations()
        {
            UseClientFor(async client =>
            {
                var conversations = await client.GetConversationsAsync();
                Assert.IsNotEmpty(conversations);
            });
        }

        [Test]
        public void TestGetConversation()
        {
            UseClientFor(async client =>
            {
                var conversation = await client.GetConversationAsync(conversationId);
                Assert.IsNotNull(conversation);
            });
           
        }

        [Test]
        public void TestGetMessage()
        {
            UseClientFor(async client =>
            {
                var messageFromIndex = await client.GetMessageAsync(conversationId, "1");
                Assert.IsNotNull(messageFromIndex);

                var messageFromId = await client.GetMessageAsync(conversationId, messageFromIndex._id);
                Assert.IsNotNull(messageFromId);
            });
        }

        [Test]
        public void TestGetVariables()
        {
            UseClientFor(async client =>
            {
                var variables = await client.GetVariablesAsync(conversationId);
                Assert.IsNotNull(variables);
            });
        }
    }
}
namespace BotSociety.Runtime
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    
    public class ApiKeyServiceClientCredentials : ServiceClientCredentials
    {
         private readonly string userId;
         private readonly string apiKey;

        /// <summary>
        /// Creates a new instance of the ApiKeyServiceClientCredentails class
        /// </summary>
        /// <param name="userId">The subscription key to authenticate and authorize as</param>
        public ApiKeyServiceClientCredentials(string userId, string apiKey)
        {
            if (string.IsNullOrWhiteSpace(userId))
                throw new ArgumentNullException(nameof(userId));

            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentNullException(nameof(apiKey));

            this.userId = userId;
            this.apiKey = apiKey;
        }

        /// <summary>
        /// Add the Basic Authentication Header to each outgoing request
        /// </summary>
        /// <param name="request">The outgoing request</param>
        /// <param name="cancellationToken">A token to cancel the operation</param>
        public override Task ProcessHttpRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            request.Headers.Add("user_id", this.userId);
            request.Headers.Add("api_key_public", this.apiKey);

            return Task.FromResult<object>(null);
        }
    }
}
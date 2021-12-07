using Moq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Xtramile.Tests
{
    public sealed class Common
    {
        static HttpClient httpClient;
        public static IHttpClientFactory GetHttpClientFactory()
        {
            var mockHttpClientFactory = new Mock<IHttpClientFactory>(MockBehavior.Strict);
            if (httpClient == null)
                httpClient = new HttpClient();
            mockHttpClientFactory.Setup(_ => _.CreateClient(string.Empty)).Returns(httpClient).Verifiable();

            return mockHttpClientFactory.Object;
        }
    }
}

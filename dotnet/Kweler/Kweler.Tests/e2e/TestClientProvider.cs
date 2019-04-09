using Kweler.Presentation.Api;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Kweler.Tests.e2e
{
    public class TestClientProvider
    {
        public HttpClient HttpClient { get; private set; }

        public TestClientProvider()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            this.HttpClient = server.CreateClient();
        }
    }
}

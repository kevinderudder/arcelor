using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Xunit;

namespace Kweler.Tests.e2e
{
    public class SongsControllerIntegrationTest
    {

     
        public async void Get_All_Songs() {
            using (var client = new TestClientProvider().HttpClient) {
                var response = await client.GetAsync("/api/songs");
                response.EnsureSuccessStatusCode();
                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            }
        }


    }
}

using System;
using Xunit;
using System.Net.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using Groot;
using System.Threading.Tasks;
using System.Net;

namespace Goot.IntegrationTests
{
    public class GuardianTests
    {
        private HttpClient Client;
        private TestServer Server;

        public GuardianTests()
        {
            //arrange
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/groot");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}

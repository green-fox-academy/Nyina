using System;
using Xunit;
using CarLicences;
using System.Net.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;
using System.Net;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private HttpClient Client;
        private TestServer Server;

        public UnitTest1()
        {
            //arrange
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task SearchApiAudiShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/api/search/audi");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task SearchApiFiatShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/api/search/fiat");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}

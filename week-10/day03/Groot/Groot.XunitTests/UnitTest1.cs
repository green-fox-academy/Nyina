using System;
using Xunit;
using System.Net.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using Groot;
using System.Threading.Tasks;
using System.Net;

namespace Groot.XunitTests
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
            var response = await Client.GetAsync("/groot?message=somemessage");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task IndexShouldReturnBadrequestStatus()
        {
            //act
            var response = await Client.GetAsync("/groot");

            //assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async Task IndexShouldReturnWrittenStatus()
        {
            //act
            var response = await Client.GetAsync("/groot");

            //assert
            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"error\":\"I am Groot!\"}", json);
        }

        [Fact]
        public async Task IndexShouldReturnWrittenOKStatus()
        {
            //act
            var response = await Client.GetAsync("/groot?message=somemessage");

            //assert
            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"received\":\"somemessage\",\"translated\":\"I am Groot!\"}", json);
        }
    }
}

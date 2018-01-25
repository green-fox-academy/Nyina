using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Yondu;


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
        public async Task IndexShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/yondu?distance=100&time=10");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task IndexShouldReturnBadrequestStatus()
        {
            //act
            var response = await Client.GetAsync("/yondu");

            //assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async Task IndexShouldReturnWrittenStatus()
        {
            //act
            var response = await Client.GetAsync("/yondu");

            //assert
            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"error\":\"Please give a not null positive number!\"}", json);
        }

        [Fact]
        public async Task IndexShouldReturnWrittenOKStatus()
        {
            //act
            var response = await Client.GetAsync("/yondu?distance=100.00&time=10.00");

            //assert
            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"distance\":100.0,\"time\":10.0\",speed\": 10.0}", json);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}

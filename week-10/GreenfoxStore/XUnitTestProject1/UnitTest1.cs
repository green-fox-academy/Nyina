using System;
using Xunit;
using GreenfoxStore;
using System.Net.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using System.Net;
using System.Threading.Tasks;

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
        public async Task WarehousePriceLowerShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/warehouse/query?price=50&type=lower");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task WarehousePriceHigherShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/warehouse/query?price=50&type=higher");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}

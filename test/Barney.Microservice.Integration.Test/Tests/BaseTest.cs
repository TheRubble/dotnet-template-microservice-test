using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Barney.Microservice.Integration.Test.Client;

namespace Barney.Microservice.Integration.Test.Tests
{
    public abstract class BaseTest
    {
        protected VersionServiceClient VersionServiceClient;

        protected BaseTest()
        {

            var server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>()
                .ConfigureTestServices(services =>
                {
                }));

            var httpClient = server.CreateClient();
            VersionServiceClient = new VersionServiceClient(httpClient);
        }
    }
}
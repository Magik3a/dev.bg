using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Logging;

namespace BlazorApp1Api
{
    public class ApplicationInfoFunction
    {
        private readonly ILogger _logger;
        private readonly HealthCheckService _healthCheck;

        public ApplicationInfoFunction(ILoggerFactory loggerFactory, HealthCheckService healthCheck)
        {
            _logger = loggerFactory.CreateLogger<ApplicationInfoFunction>();
            _healthCheck = healthCheck;
        }

        [Function("health")]
        public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
           
            var healthStatus = await _healthCheck.CheckHealthAsync();

            await response.WriteAsJsonAsync(healthStatus).ConfigureAwait(false);

            return response;
        }
    }
}

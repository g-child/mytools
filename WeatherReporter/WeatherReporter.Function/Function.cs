using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;

namespace WeatherReporter.Function
{
    public static class Function
    {
        [FunctionName("Function")]
        public static void Run([TimerTrigger("*/5 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
